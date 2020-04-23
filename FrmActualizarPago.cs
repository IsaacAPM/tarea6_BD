using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea6 {
    public partial class FrmActualizarPago : Form {
        //Variables de clase
        PréstamosEntities context = new PréstamosEntities();
        BindingSource PreBS = new BindingSource();
        List<Clientes> listClien; List<Préstamos> listPres; List<Pagos> listPagos;

        public FrmActualizarPago() {
            InitializeComponent();
        }

        private void FrmActualizarPago_Load(object sender, EventArgs e) {
            //Carga los datos de las tablas requeridas.
            context.Préstamos.Load();
            context.Clientes.Load();
            context.Pagos.Load();

            DtgGeneral.DataSource = context.Pagos.Local;

            //Carga el combo de clientes con los nombres
            foreach (Clientes c in context.Clientes)
                CboClientes.Items.Add(c.Nombre);
        }

        private void CboClientes_SelectedIndexChanged(object sender, EventArgs e) {
            //Desbloquea el ComboBox CboPréstamos
            CboPréstamos.Enabled = true;
            
        }
    }
}
