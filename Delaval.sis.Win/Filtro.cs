using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delaval.sis.Service;
using Delaval.sis.Entity;
namespace Delaval.sis.Win
{
    public partial class Filtro : Form
    {
        EquipoService es = new EquipoService();
        ModeloService me = new ModeloService();

    List<EquipoEntity> listaEquipo;
List<ModeloEntity> listaModelo;
        public Filtro()
        {
            InitializeComponent();
        }

        //LISTA COMBO EQUIPO
        public void ListarComboEquipo()
        {
            listaEquipo = new List<EquipoEntity>();
            listaEquipo = es.listarEquipo();
            Dictionary<int, String> dicTemp = new Dictionary<int, string>();

            foreach (var entidad in listaEquipo)
            {

                dicTemp.Add(Convert.ToInt32(entidad.idEquipo), entidad.nombre);

            }

            cboEquipos.DataSource = new BindingSource(dicTemp, null);

            cboEquipos.DisplayMember = "Value";
            cboEquipos.ValueMember = "Key";
        }

        //LISTA COMBO MODELO
        public void ListarComboModelo()
        {
            listaModelo = new List<ModeloEntity>();
            listaModelo = me.listarModelos();
            Dictionary<int, String> dicTemp = new Dictionary<int, string>();

            foreach (var entidad in listaModelo)
            {

                dicTemp.Add(Convert.ToInt32(entidad.idModelos), entidad.NombreModelo);

            }

            cboModelo.DataSource = new BindingSource(dicTemp, null);

            cboModelo.DisplayMember = "Value";
            cboModelo.ValueMember = "Key";
        }


        private void Filtro_Load(object sender, EventArgs e)
        {
            ListarComboEquipo();
            ListarComboModelo();
        }
    }
}
