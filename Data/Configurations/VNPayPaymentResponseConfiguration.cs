
using Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class VNPayPaymentResponseConfiguration : IEntityTypeConfiguration<VNPayPaymentResponse>
    {
        public void Configure(EntityTypeBuilder<VNPayPaymentResponse> builder)
        {
            builder.ToTable(nameof(VNPayPaymentResponse));
            builder.HasKey(x => x.ResponseId);
            builder.Property(x => x.TxnRef).IsRequired();
            builder.Property(x => x.OrderId).IsRequired(false);
            builder.Property(x => x.BankCode).IsRequired();
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.BankTranNo).IsRequired();
            builder.Property(x => x.CardType).IsRequired();
            builder.Property(x => x.OrderInfo).IsRequired();
            builder.Property(x => x.PayDate).IsRequired();
            builder.Property(x => x.ResponseCode).IsRequired();
            builder.Property(x => x.TmnCode).IsRequired();
            builder.Property(x => x.TransactionNo).IsRequired();
            builder.Property(x => x.TransactionStatus).IsRequired();
            builder.Property(x => x.SecureHash).IsRequired();
            builder.Property(x => x.TypePayment).IsRequired();
            #region config relation
            builder.HasOne(x => x.Order)
                      .WithMany(c => c.VNPayPaymentResponses)
                      .HasForeignKey(x => x.OrderId)
                      .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}