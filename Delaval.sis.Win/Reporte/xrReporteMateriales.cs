using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Delaval.sis.Entity;
using System.Collections.Generic;

namespace Delaval.sis.Win.Reporte
{
    public partial class xrReporteMateriales : DevExpress.XtraReports.UI.XtraReport
    {

        public List<ArticuloEntity> lista { get; set; }
        
        public xrReporteMateriales(List<ArticuloEntity> lst)
        {
            InitializeComponent();
            this.objectDataSource1.DataSource = lst;
            this.DataSource = lst;
            lista = lst;
           
           
        }

        //private void xrReporteMateriales_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        //{
           
           

        //    if (lista.Count != 0)
        //    {
        //        ((xrReporteMateriales)((XRSubreport)sender).ReportSource).DataSource = lista2)
        //        //xrlblTotal.Text = "";
        //        //xrlblTotalEscrito.Text = "";
        //        //decimal total1 = lista.Sum(a => a.Precio);
        //        //xrlblTotal.Text = total1.ToString("0.00", clsBase.FormatoDecimal());
        //        //xrlblTotalEscrito.Text = FirstCharToUpper(NumerosAPalabras(total1));
        //        //xrTotalProduc.Visible = false;
        //        //xrTotalProNum.Visible = false;
        //    }
        //}
    }
}
