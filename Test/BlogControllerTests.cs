using ATO_API.Controllers;
using ATO_API.Controllers.ContentModerators;
using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Nest;
using Service.BlogSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class BlogControllerTests
    {
        private Mock<IBlogService> _mockBlogService;
        private Mock<IMapper> _mockMapper;
        private ATO_API.Controllers.BlogController _controller;
        private ATO_API.Controllers.ContentModerators.BlogController _controller_CM;

        [TestInitialize]
        public void Setup()
        {
            _mockBlogService = new Mock<IBlogService>();
            _mockMapper = new Mock<IMapper>();
            _controller = new ATO_API.Controllers.BlogController(_mockBlogService.Object, _mockMapper.Object);
            _controller_CM = new ATO_API.Controllers.ContentModerators.BlogController(_mockBlogService.Object, _mockMapper.Object);
        }
        [TestMethod]
        public async Task GetBlogs_ReturnsOk_WhenBlogsExist()
        {
            // Arrange
            var blogs = new List<Blog>
        {
            new Blog { BlogId = Guid.NewGuid(), Title = "Test Blog 1", Content = "Content 1" },
            new Blog { BlogId = Guid.NewGuid(), Title = "Test Blog 2", Content = "Content 2" }
        };

            var blogGuestDTOs = new List<Blog_Guest_DTO>
        {
            new Blog_Guest_DTO { BlogId = blogs[0].BlogId, Title = blogs[0].Title, Content = blogs[0].Content },
            new Blog_Guest_DTO { BlogId = blogs[1].BlogId, Title = blogs[1].Title, Content = blogs[1].Content }
        };

            _mockBlogService.Setup(x => x.GetListBlogs()).ReturnsAsync(blogs);
            _mockMapper.Setup(m => m.Map<List<Blog_Guest_DTO>>(It.IsAny<List<Blog>>())).Returns(blogGuestDTOs);

            // Act
            var result = await _controller.GetBlogs() as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var response = result.Value as List<Blog_Guest_DTO>;
            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.Count);
            Assert.AreEqual("Test Blog 1", response[0].Title);
        }

        [TestMethod]
        public async Task GetBlogs_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            _mockBlogService.Setup(x => x.GetListBlogs()).ThrowsAsync(new Exception("Error retrieving blogs"));

            // Act
            var result = await _controller.GetBlogs() as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Error retrieving blogs", response.Message);
        }
        [TestMethod]
        public async Task GetBlogDetails_ReturnsOk_WhenBlogExists()
        {
            // Arrange
            var blogId = Guid.NewGuid();
            var blog = new Blog { BlogId = blogId, Title = "Test Blog", Content = "Blog Content" };
            var blogGuestDTO = new Blog_Guest_DTO { BlogId = blogId, Title = "Test Blog", Content = "Blog Content" };

            _mockBlogService.Setup(x => x.GetBlogDetails(blogId)).ReturnsAsync(blog);
            _mockMapper.Setup(m => m.Map<Blog_Guest_DTO>(It.IsAny<Blog>())).Returns(blogGuestDTO);

            // Act
            var result = await _controller.GetBlogDetails(blogId) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var response = result.Value as Blog_Guest_DTO;
            Assert.IsNotNull(response);
            Assert.AreEqual("Test Blog", response.Title);
        }

        [TestMethod]
        public async Task GetBlogDetails_ReturnsBadRequest_WhenBlogNotFound()
        {
            // Arrange
            var blogId = Guid.NewGuid();
            _mockBlogService.Setup(x => x.GetBlogDetails(blogId)).ReturnsAsync((Blog)null);

            // Act
            var result = await _controller.GetBlogDetails(blogId) as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(400, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Không tìm thấy bài viết", response.Message);
        }

        [TestMethod]
        public async Task GetBlogDetails_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            var blogId = Guid.NewGuid();
            _mockBlogService.Setup(x => x.GetBlogDetails(blogId)).ThrowsAsync(new Exception("Error retrieving blog details"));

            // Act
            var result = await _controller.GetBlogDetails(blogId) as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Error retrieving blog details", response.Message);
        }
        [TestMethod]
        public async Task GetBlogs_ReturnsOk_WhenBlogsExist_CM()
        {
            // Arrange
            var mockBlogService = new Mock<IBlogService>();
            mockBlogService.Setup(service => service.GetListBlogs_CM()).ReturnsAsync(new List<Blog>());
            var mockMapper = new Mock<IMapper>();
            var controller = new ATO_API.Controllers.ContentModerators.BlogController(mockBlogService.Object, mockMapper.Object);

            // Act
            var result = await controller.GetBlogs();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }
        [TestMethod]
        public void UpdateReplyRequestDto_ShouldHaveValidProperties()
        {
            // Arrange
            var updateReplyRequest = new UpdateReplyRequestDto
            {
                ReplyContent = "This is a new reply content",
                NewStatus = BlogStatus.Approval
            };

            // Act & Assert
            Assert.IsNotNull(updateReplyRequest.ReplyContent);
            Assert.AreEqual("This is a new reply content", updateReplyRequest.ReplyContent);

            Assert.AreEqual(BlogStatus.Approval, updateReplyRequest.NewStatus);
        }

    }

}
