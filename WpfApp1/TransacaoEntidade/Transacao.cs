using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransacaoEntidade
{
     public class Transacao
        {
            private string merchantCnpj;
            private int checkoutCode;
            private string cipheredCardNumber;
            private int amountInCents;
            private int installments;
            private string acquirerName;
            private string paymentMethod;
            private string cardBrandName;
            private string status;
            private string statusInfo;
            private System.DateTime createdAt;
            private System.DateTime acquirerAuthorizationDateTime;

            public Transacao(string merchantCnpj
                             , int checkoutCode
                             , string cipheredCardNumber
                             , int amountInCents
                             , int installments
                             , string acquirerName
                             , string paymentMethod
                             , string cardBrandName
                             , string status
                             , string statusInfo
                             , System.DateTime createdAt
                             , System.DateTime acquirerAuthorizationDateTime)
            {
                this.MerchantCnpj = merchantCnpj;
                this.CheckoutCode = checkoutCode;
                this.CipheredCardNumber = cipheredCardNumber;
                this.AmountInCents = amountInCents;
                this.Installments = installments;
                this.AcquirerName = acquirerName;
                this.PaymentMethod = paymentMethod;
                this.CardBrandName = cardBrandName;
                this.Status = status;
                this.StatusInfo = statusInfo;
                this.CreatedAt = createdAt;
                this.AcquirerAuthorizationDateTime = acquirerAuthorizationDateTime;

            }

            public string MerchantCnpj
            {
                get
                {
                    return merchantCnpj;
                }
                set
                {
                    merchantCnpj = value;
                }
            }

            public int CheckoutCode
            {
                get
                {
                    return checkoutCode;
                }
                set
                {
                    checkoutCode = value;
                }
            }

            public string CipheredCardNumber
            {
                get
                {
                    return cipheredCardNumber;
                }
                set
                {
                    cipheredCardNumber = value;
                }
            }

            public int AmountInCents
            {
                get
                {
                    return amountInCents;
                }
                set
                {
                    amountInCents = value;
                }
            }

            public int Installments
            {
                get
                {
                    return installments;
                }
                set
                {
                    installments = value;
                }
            }

            public string AcquirerName
            {
                get
                {
                    return acquirerName;
                }
                set
                {
                    acquirerName = value;
                }
            }

            public string PaymentMethod
            {
                get
                {
                    return paymentMethod;
                }
                set
                {
                    paymentMethod = value;
                }
            }

            public string CardBrandName
            {
                get
                {
                    return cardBrandName;
                }
                set
                {
                    cardBrandName = value;
                }
            }

            public string Status
            {
                get
                {
                    return status;
                }
                set
                {
                    status = value;
                }
            }

            public string StatusInfo
            {
                get
                {
                    return statusInfo;
                }
                set
                {
                    statusInfo = value;
                }
            }

            public System.DateTime CreatedAt
            {
                get
                {
                    return createdAt;
                }
                set
                {
                    createdAt = value;
                }
            }

            public System.DateTime AcquirerAuthorizationDateTime
            {
                get
                {
                    return acquirerAuthorizationDateTime;
                }
                set
                {
                    acquirerAuthorizationDateTime = value;
                }
            }
        }
   
}
