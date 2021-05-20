using Mustache;
using EnviTest.Models;
using System.IO;
using System.Web;
using System.Xml;

namespace EnviTest.Services
{
    public class InvoiceXMLServices
    {
        #region B2B 交換 相關

        /// <summary>
        /// 開立發票訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorA0101(InvoiceA0101 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateA0101.txt", "urn:GEINV:eInvoiceMessage:A0101:3.2", @"~/einv/xsd/v32/A0101.xsd");
        }

        /// <summary>
        /// 發票接收確認訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorA0102(InvoiceA0102 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateA0102.txt", "urn:GEINV:eInvoiceMessage:A0102:3.2", @"~/einv/xsd/v32/A0102.xsd");
        }

        /// <summary>
        /// 開立折讓證明單訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorB0101(InvoiceB0101 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateB0101.txt", "urn:GEINV:eInvoiceMessage:B0101:3.2", @"~/einv/xsd/v32/B0101.xsd");
        }

        /// <summary>
        /// 開立折讓證明/通知單接收確認訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorB0102(InvoiceB0102 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateB0102.txt", "urn:GEINV:eInvoiceMessage:B0102:3.2", @"~/einv/xsd/v32/B0102.xsd");
        }

        /// <summary>
        /// 作廢發票訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorA0201(InvoiceA0201 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateA0201.txt", "urn:GEINV:eInvoiceMessage:A0201:3.2", @"~/einv/xsd/v32/A0201.xsd");
        }

        /// <summary>
        /// 作廢發票接收確認訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorA0202(InvoiceA0202 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateA0202.txt", "urn:GEINV:eInvoiceMessage:A0202:3.2", @"~/einv/xsd/v32/A0202.xsd");
        }

        /// <summary>
        /// 作廢折讓證明單訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorB0201(InvoiceB0201 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateB0201.txt", "urn:GEINV:eInvoiceMessage:B0201:3.2", @"~/einv/xsd/v32/B0201.xsd");
        }

        /// <summary>
        /// 作廢折讓證明單接收確認訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorB0202(InvoiceB0202 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateB0202.txt", "urn:GEINV:eInvoiceMessage:B0202:3.2", @"~/einv/xsd/v32/B0202.xsd");
        }

        /// <summary>
        /// 退回(拒收)發票訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorA0301(InvoiceA0301 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateA0301.txt", "urn:GEINV:eInvoiceMessage:A0301:3.2", @"~/einv/xsd/v32/A0301.xsd");
        }

        /// <summary>
        /// 退回(拒收)發票接收確認訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorA0302(InvoiceA0302 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateA0302.txt", "urn:GEINV:eInvoiceMessage:A0302:3.2", @"~/einv/xsd/v32/A0302.xsd");
        }

        #endregion

        #region B2B 相關

        /// <summary>
        /// 平台存證開立發票訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorA0401(InvoiceA0401 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateA0401.txt", "urn:GEINV:eInvoiceMessage:A0401:3.2", @"~/einv/xsd/v32/A0401.xsd");
        }

        /// <summary>
        /// 平台存證開立折讓證明/通知單訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorB0401(InvoiceB0401 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateB0401.txt", "urn:GEINV:eInvoiceMessage:B0401:3.2", @"~/einv/xsd/v32/B0401.xsd");
        }

        /// <summary>
        /// 平台存證作廢發票訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorA0501(InvoiceA0501 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateA0501.txt", "urn:GEINV:eInvoiceMessage:A0501:3.2", @"~/einv/xsd/v32/A0501.xsd");
        }

        /// <summary>
        /// 平台存證作廢折讓證明單訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorB0501(InvoiceB0501 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateB0501.txt", "urn:GEINV:eInvoiceMessage:B0501:3.2", @"~/einv/xsd/v32/B0501.xsd");
        }

        /// <summary>
        /// 平台存證退回(拒收)發票訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorA0601(InvoiceA0601 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateA0601.txt", "urn:GEINV:eInvoiceMessage:A0601:3.2", @"~/einv/xsd/v32/A0601.xsd");
        }

        #endregion

        #region B2C 相關

        /// <summary>
        /// 平台存證開立發票訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorC0401(InvoiceC0401 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateC0401.txt", "urn:GEINV:eInvoiceMessage:C0401:3.2", @"~/einv/xsd/v32/C0401.xsd");
        }

        /// <summary>
        /// 平台存證作廢發票訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorC0501(InvoiceC0501 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateC0501.txt", "urn:GEINV:eInvoiceMessage:C0501:3.2", @"~/einv/xsd/v32/C0501.xsd");
        }

        /// <summary>
        /// 註銷發票訊息存證規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorC0701(InvoiceC0701 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateC0701.txt", "urn:GEINV:eInvoiceMessage:C0701:3.2", @"~/einv/xsd/v32/C0701.xsd");
        }

        /// <summary>
        /// 平台存證開立折讓證明單/傳送折讓證明單通知
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorD0401(InvoiceD0401 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateD0401.txt", "urn:GEINV:eInvoiceMessage:D0401:3.2", @"~/einv/xsd/v32/D0401.xsd");
        }

        /// <summary>
        /// 平台存證作廢折讓證明單訊息規格
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorD0501(InvoiceD0501 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateD0501.txt", "urn:GEINV:eInvoiceMessage:D0501:3.2", @"~/einv/xsd/v32/D0501.xsd");
        }

        #endregion

        #region B2P 相關

        /// <summary>
        /// 分支機構配號檔
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorE0401(InvoiceE0401 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateE0401.txt", "urn:GEINV:eInvoiceMessage:E0401:3.2", @"~/einv/xsd/v32/E0401.xsd");
        }

        /// <summary>
        /// 空白未使用字軌檔
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GeneratorE0402(InvoiceE0402 data)
        {
            return this.GeneratorXML(data, @"~/einv/template/templateE0402.txt", "urn:GEINV:eInvoiceMessage:E0402:3.2", @"~/einv/xsd/v32/E0402.xsd");
        }

        #endregion

        #region 共用方法

        protected string GeneratorXML(object data, string templatePath, string xsdNamespace, string xsdPath)
        {
            string template = File.ReadAllText(HttpContext.Current.Server.MapPath(templatePath));

            HtmlFormatCompiler compiler = new HtmlFormatCompiler();
            Generator generator = compiler.Compile(template);

            string resultXML = generator.Render(new { data });

            //驗證產出的XML是否符合xsd的規範
            XmlReaderSettings xmlReadersettings = new XmlReaderSettings();
            xmlReadersettings.Schemas.Add(xsdNamespace, HttpContext.Current.Server.MapPath(xsdPath));
            xmlReadersettings.ValidationType = ValidationType.Schema;

            XmlReader reader = XmlReader.Create(new StringReader(resultXML), xmlReadersettings);
            XmlDocument document = new XmlDocument();

            document.Load(reader);

            return resultXML;
        }

        #endregion
    }
}