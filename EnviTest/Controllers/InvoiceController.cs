using EnviTest.Models;
using EnviTest.Services;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace EnviTest.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public ActionResult Index()
        {
            return View();
        }

        #region B2B 交換 相關

        public ActionResult TestA0101()
        {
            InvoiceA0101 model = new InvoiceA0101()
            {
                // Main
                InvoiceNumber = "QE00000000",
                InvoiceDate = "20210419",
                InvoiceTime = "16:20:17",
                SellerIdentifier = "12345678",
                SellerName = "測試股份有限公司",
                BuyerIdentifier = "0000000000",
                BuyerName = "測試購買者",
                InvoiceType = "07",
                DonateMark = "0",
                // Amount
                SalesAmount = "100",
                TaxType = "1",
                TaxRate = "0.05",
                TaxAmount = "5",
                TotalAmount = "105"
            };
            // Details
            model.ProductItems = new List<InvoiceA0101ProductItem>();
            model.ProductItems.Add(new InvoiceA0101ProductItem()
            {
                Description = "測試品項",
                Quantity = "1",
                Unit = "個",
                UnitPrice = "100",
                Amount = "100",
                SequenceNumber = "1"
            });

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorA0101(model), "text/xml");
        }

        public ActionResult TestA0102()
        {
            InvoiceA0102 model = new InvoiceA0102()
            {
                InvoiceNumber = "QE00000000",
                InvoiceDate = "20210419",
                SellerId = "12345678",
                BuyerId = "0000000000",
                ReceiveDate = "20210519",
                ReceiveTime = "16:20:17",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorA0102(model), "text/xml");
        }

        public ActionResult TestB0101()
        {
            InvoiceB0101 model = new InvoiceB0101()
            {
                // Main
                AllowanceNumber = "QE00000000",
                AllowanceDate = "20210519",
                SellerIdentifier = "12345678",
                SellerName = "測試股份有限公司",
                BuyerIdentifier = "0000000000",
                BuyerName = "測試購買者",
                AllowanceType = "2",
                // Amount
                TaxAmount = "0",
                TotalAmount = "10"
            };
            // Details
            model.ProductItems = new List<InvoiceB0101ProductItem>();
            model.ProductItems.Add(new InvoiceB0101ProductItem()
            {
                OriginalInvoiceDate = "20210419",
                OriginalInvoiceNumber = "QE00000000",
                OriginalSequenceNumber = "1",
                OriginalDescription = "測試品項",
                Quantity = "1",
                Unit = "個",
                UnitPrice = "10",
                Amount = "10",
                Tax = "0",
                AllowanceSequenceNumber = "1",
                TaxType = "3"
            });

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorB0101(model), "text/xml");
        }

        public ActionResult TestB0102()
        {
            InvoiceB0102 model = new InvoiceB0102()
            {
                AllowanceNumber = "QE00000000",
                AllowanceDate = "20210419",
                SellerId = "12345678",
                BuyerId = "0000000000",
                ReceiveDate = "20210519",
                ReceiveTime = "16:20:17",
                AllowanceType = "2",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorB0102(model), "text/xml");
        }

        public ActionResult TestA0201()
        {
            InvoiceA0201 model = new InvoiceA0201()
            {
                CancelInvoiceNumber = "QE00000000",
                InvoiceDate = "20210419",
                SellerId = "12345678",
                BuyerId = "0000000000",
                CancelDate = "20210519",
                CancelTime = "16:20:17",
                CancelReason = "測試",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorA0201(model), "text/xml");
        }

        public ActionResult TestA0202()
        {
            InvoiceA0202 model = new InvoiceA0202()
            {
                CancelInvoiceNumber = "QE00000000",
                InvoiceDate = "20210419",
                SellerId = "12345678",
                BuyerId = "0000000000",
                CancelDate = "20210519",
                CancelTime = "16:20:17",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorA0202(model), "text/xml");
        }

        public ActionResult TestB0201()
        {
            InvoiceB0201 model = new InvoiceB0201()
            {
                CancelAllowanceNumber = "QE00000000",
                AllowanceDate = "20210619",
                SellerId = "12345678",
                BuyerId = "0000000000",
                CancelDate = "20210519",
                CancelTime = "16:20:17",
                CancelReason = "測試",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorB0201(model), "text/xml");
        }

        public ActionResult TestB0202()
        {
            InvoiceB0202 model = new InvoiceB0202()
            {
                CancelAllowanceNumber = "QE00000000",
                AllowanceDate = "20210619",
                SellerId = "12345678",
                BuyerId = "0000000000",
                CancelDate = "20210519",
                CancelTime = "16:20:17",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorB0202(model), "text/xml");
        }

        public ActionResult TestA0301()
        {
            InvoiceA0301 model = new InvoiceA0301()
            {
                RejectInvoiceNumber = "QE00000000",
                InvoiceDate = "20210619",
                SellerId = "12345678",
                BuyerId = "0000000000",
                RejectDate = "20210519",
                RejectTime = "16:20:17",
                RejectReason = "測試",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorA0301(model), "text/xml");
        }

        public ActionResult TestA0302()
        {
            InvoiceA0302 model = new InvoiceA0302()
            {
                RejectInvoiceNumber = "QE00000000",
                InvoiceDate = "20210619",
                SellerId = "12345678",
                BuyerId = "0000000000",
                RejectDate = "20210519",
                RejectTime = "16:20:17",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorA0302(model), "text/xml");
        }

        #endregion

        #region B2B 相關

        public ActionResult TestA0401()
        {
            InvoiceA0401 model = new InvoiceA0401()
            {
                // Main
                InvoiceNumber = "QE00000000",
                InvoiceDate = "20210419",
                InvoiceTime = "16:20:17",
                SellerIdentifier = "12345678",
                SellerName = "測試股份有限公司",
                BuyerIdentifier = "0000000000",
                BuyerName = "測試購買者",
                InvoiceType = "07",
                DonateMark = "0",
                // Amount
                SalesAmount = "100",
                TaxType = "1",
                TaxRate = "0.05",
                TaxAmount = "5",
                TotalAmount = "105"
            };
            // Details
            model.ProductItems = new List<InvoiceA0401ProductItem>();
            model.ProductItems.Add(new InvoiceA0401ProductItem()
            {
                Description = "測試品項",
                Quantity = "1",
                Unit = "個",
                UnitPrice = "100",
                Amount = "100",
                SequenceNumber = "1"
            });

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorA0401(model), "text/xml");
        }

        public ActionResult TestB0401()
        {
            InvoiceB0401 model = new InvoiceB0401()
            {
                // Main
                AllowanceNumber = "QE00000000",
                AllowanceDate = "20210519",
                SellerIdentifier = "12345678",
                SellerName = "測試股份有限公司",
                BuyerIdentifier = "0000000000",
                BuyerName = "測試購買者",
                AllowanceType = "2",
                // Amount
                TaxAmount = "0",
                TotalAmount = "10"
            };
            // Details
            model.ProductItems = new List<InvoiceB0401ProductItem>();
            model.ProductItems.Add(new InvoiceB0401ProductItem()
            {
                OriginalInvoiceDate = "20210419",
                OriginalInvoiceNumber = "QE00000000",
                OriginalSequenceNumber = "1",
                OriginalDescription = "測試品項",
                Quantity = "1",
                Unit = "個",
                UnitPrice = "10",
                Amount = "10",
                Tax = "0",
                AllowanceSequenceNumber = "1",
                TaxType = "3"
            });

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorB0401(model), "text/xml");
        }

        public ActionResult TestA0501()
        {
            InvoiceA0501 model = new InvoiceA0501()
            {
                CancelInvoiceNumber = "QE00000000",
                InvoiceDate = "20210419",
                CancelDate = "20210519",
                CancelTime = "16:20:17",
                SellerId = "12345678",
                BuyerId = "0000000000",
                CancelReason = "測試",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorA0501(model), "text/xml");
        }

        public ActionResult TestB0501()
        {
            InvoiceB0501 model = new InvoiceB0501()
            {
                CancelAllowanceNumber = "QE00000000",
                AllowanceDate = "20210619",
                CancelDate = "20210519",
                CancelTime = "16:20:17",
                SellerId = "12345678",
                BuyerId = "0000000000",
                CancelReason = "測試",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorB0501(model), "text/xml");
        }

        public ActionResult TestA0601()
        {
            InvoiceA0601 model = new InvoiceA0601()
            {
                RejectInvoiceNumber = "QE00000000",
                InvoiceDate = "20210419",
                RejectDate = "20210519",
                RejectTime = "16:20:17",
                SellerId = "12345678",
                BuyerId = "0000000000",
                RejectReason = "測試",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorA0601(model), "text/xml");
        }

        #endregion

        #region B2C 相關

        public ActionResult TestC0401()
        {
            InvoiceC0401 model = new InvoiceC0401()
            {
                // Main
                InvoiceNumber = "QE00000000",
                InvoiceDate = "20210419",
                InvoiceTime = "16:20:17",
                SellerIdentifier = "12345678",
                SellerName = "測試股份有限公司",
                BuyerIdentifier = "0000000000",
                BuyerName = "測試購買者",
                InvoiceType = "07",
                DonateMark = "0",
                PrintMark = "Y",
                RandomNumber = "0001",
                // Amount
                SalesAmount = "100",
                FreeTaxSalesAmount = "0",
                ZeroTaxSalesAmount = "0",
                TaxType = "1",
                TaxRate = "0.05",
                TaxAmount = "5",
                TotalAmount = "105"
            };
            // Details
            model.ProductItems = new List<InvoiceC0401ProductItem>();
            model.ProductItems.Add(new InvoiceC0401ProductItem()
            {
                Description = "測試品項",
                Quantity = "1",
                Unit = "個",
                UnitPrice = "100",
                Amount = "100",
                SequenceNumber = "1"
            });

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorC0401(model), "text/xml");
        }

        public ActionResult TestC0501()
        {
            InvoiceC0501 model = new InvoiceC0501()
            {
                CancelInvoiceNumber = "QE00000000",
                InvoiceDate = "20210419",
                CancelDate = "20210519",
                CancelTime = "16:20:17",
                SellerId = "12345678",
                BuyerId = "0000000000",
                CancelReason = "測試",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorC0501(model), "text/xml");
        }

        public ActionResult TestC0701()
        {
            InvoiceC0701 model = new InvoiceC0701()
            {
                VoidInvoiceNumber = "QE00000000",
                InvoiceDate = "20210419",
                VoidDate = "20210519",
                VoidTime = "16:20:17",
                SellerId = "12345678",
                BuyerId = "0000000000",
                VoidReason = "測試",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorC0701(model), "text/xml");
        }

        public ActionResult TestD0401()
        {
            InvoiceD0401 model = new InvoiceD0401()
            {
                // Main
                AllowanceNumber = "QE00000000",
                AllowanceDate = "20210519",
                SellerIdentifier = "12345678",
                SellerName = "測試股份有限公司",
                BuyerIdentifier = "0000000000",
                BuyerName = "測試購買者",
                AllowanceType = "2",
                // Amount
                TaxAmount = "0",
                TotalAmount = "10"
            };
            // Details
            model.ProductItems = new List<InvoiceD0401ProductItem>();
            model.ProductItems.Add(new InvoiceD0401ProductItem()
            {
                OriginalInvoiceDate = "20210419",
                OriginalInvoiceNumber = "QE00000000",
                OriginalSequenceNumber = "1",
                OriginalDescription = "測試品項",
                Quantity = "1",
                Unit = "個",
                UnitPrice = "10",
                Amount = "10",
                Tax = "0",
                AllowanceSequenceNumber = "1",
                TaxType = "3"
            });

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorD0401(model), "text/xml");
        }

        public ActionResult TestD0501()
        {
            InvoiceD0501 model = new InvoiceD0501()
            {
                CancelAllowanceNumber = "QE00000000",
                AllowanceDate = "20210619",
                CancelDate = "20210519",
                CancelTime = "16:20:17",
                SellerId = "12345678",
                BuyerId = "0000000000",
                CancelReason = "測試",
            };

            InvoiceXMLServices service = new InvoiceXMLServices();
            // 下載檔案的方式
            var result = new FileContentResult(Encoding.UTF8.GetBytes(service.GeneratorD0501(model)), "text/xml");
            result.FileDownloadName = "TestD0501.xml";
            return result;
            //return Content(service.GeneratorD0501(model), "text/xml");
        }

        #endregion

        #region B2P 相關

        public ActionResult TestE0401()
        {
            InvoiceE0401 model = new InvoiceE0401()
            {
                // Main
                HeadBan = "12345678",
                BranchBan = "0000000000",
                InvoiceType = "07",
                YearMonth = "11004",
                InvoiceTrack = "QB",
                InvoiceBeginNo = "00001000",
                InvoiceEndNo = "00001999",
            };
            // Details
            model.BranchTrackItems = new List<InvoiceE0401BranchTrackItem>();
            model.BranchTrackItems.Add(new InvoiceE0401BranchTrackItem()
            {
                InvoiceBeginNo = "00001000",
                InvoiceEndNo = "00001499",
                InvoiceBooklet = "10",
            });

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorE0401(model), "text/xml");
        }

        public ActionResult TestE0402()
        {
            InvoiceE0402 model = new InvoiceE0402()
            {
                // Main
                HeadBan = "12345678",
                BranchBan = "0000000000",
                InvoiceType = "07",
                YearMonth = "11004",
                InvoiceTrack = "QB",
            };
            // Details
            model.BranchTrackBlankItems = new List<InvoiceE0402BranchTrackBlankItem>();
            model.BranchTrackBlankItems.Add(new InvoiceE0402BranchTrackBlankItem()
            {
                InvoiceBeginNo = "00001000",
                InvoiceEndNo = "00001499",
            });

            InvoiceXMLServices service = new InvoiceXMLServices();
            return Content(service.GeneratorE0402(model), "text/xml");
        }

        #endregion
    }
}