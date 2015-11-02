using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionAdministrativa.Data;
using GestionAdministrativa.Win;
using GestionAdministrativa.Win.Forms;
using Telerik.WinControls;

namespace GestionAdministrativa.Win.Forms
{
    public partial class FrmPrincipal : FormBase
    {

        public FrmPrincipal(IFormFactory formFactory, GestionAdministrativaUow uow)//, IUowFactory uowFactory)
        {
            FormFactory = formFactory;
            Uow = uow;
           // UowFactory = uowFactory;
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            //var frm = FormFactory.Create<FrmClienteListado>();
           /// frm.ShowDialog();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
          // var frm = FormFactory.Create<FrmVentas>();
          //  frm.ShowDialog();
        }

        private void BtnCobradores_Click(object sender, EventArgs e)
        {
            //var frm = FormFactory.Create<FrmCrearEditarCobrador>();
            //frm.ShowDialog();
        }

      
    }
}
