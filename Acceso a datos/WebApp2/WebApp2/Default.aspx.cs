using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp2.Models;

namespace WebApp2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DAM_urkourbieta_DEVEntities1 contexto = new DAM_urkourbieta_DEVEntities1())
            {
                //List<Empleados> depts = contexto.getEmpleados().ToList();
                GridView1.DataSource = contexto.getEmpleados().ToList();
                GridView1.DataBind();
            }

        }
    }
}