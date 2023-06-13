using App.Core.Business;
using App.Core.Entities;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private MailBusiness _mailBusiness;
        private int currentPageIndex = 1;
        private bool _txtPageIndexBlock = false;
        public Form1()
        {
            _mailBusiness = new MailBusiness();
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTamañoPagina.SelectedIndex = cbTamañoPagina.FindStringExact("10");

            txtPageIndex.Text = currentPageIndex.ToString();

        }

        private void CargarDatos(int pageIndex)
        {
            var pageSize = int.Parse(cbTamañoPagina.SelectedItem.ToString());

            _txtPageIndexBlock = true;
            txtPageIndex.Text = pageIndex.ToString();
            _txtPageIndexBlock = false;

            var mailBusqueda = new BusquedaGenerica<Mail>() 
            {
                TextToSearch = txtSearch.Text,
                PageIndex = pageIndex,
                PageSize = pageSize,
            };

            _ = _mailBusiness.SearchGeneric(mailBusqueda);

            dataGridView1.DataSource = mailBusqueda.Items;
            
            lblBusqueda.Text = $"Correos del {pageIndex*pageSize} al {pageIndex*pageSize + pageSize}, de un total de {mailBusqueda.Total} correos.";
        }

        private void txtPageIndex_TextChanged(object sender, EventArgs e)
        {
            if (_txtPageIndexBlock)
            {
                return;
            }
            //currentPageIndex = int.Parse(txtPageIndex.Text);

            int index;

            if (int.TryParse(txtPageIndex.Text, out index))
            {
                currentPageIndex = index;
            }
            else
            {
                currentPageIndex = 1;
            }

            CargarDatos(currentPageIndex);
        }

        private void cbTamañoPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            CargarDatos(currentPageIndex);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            CargarDatos(currentPageIndex);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentPageIndex == 1)
            {
                return;
            }
            currentPageIndex--;
            CargarDatos(currentPageIndex);
            //txtPageIndex.Text = currentPageIndex.ToString();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            currentPageIndex++;
            CargarDatos(currentPageIndex);
            //txtPageIndex.Text = currentPageIndex.ToString();
        }


    }
}