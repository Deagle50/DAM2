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
        DateTime principio, fin;
        DAM_urkourbieta_DEVEntities1 contexto = new DAM_urkourbieta_DEVEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            

        }

        protected void btnMostrar1_Click(object sender, EventArgs e)
        {   
            var ID = txtID.Text.ToString();
            //Departamentos dept
            Departamentos d1 = contexto.Departamentos.Where(d => d.DeptID == ID).FirstOrDefault();
            if(d1!=null)
            Response.Write(d1.Nombre);
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            principio = DateTime.Now;
            Response.Write("PRINCIPIO");
            //List<Empleados> depts = contexto.getEmpleados().ToList();
            GridView1.DataSource = contexto.getDepartamentos().ToList();
            GridView1.DataBind();

            //List<Departamentos> depts = contexto.Departamentos.ToList();
            /*List<Departamentos> depts2 = contexto.Departamentos.Include("Empleados").ToList();
            foreach (Departamentos dept in depts2)
            {
                Response.Write(dept.Nombre);
                Response.Write("<BR>");
            }*/
            
            List<Empleados> emps = contexto.Empleados.ToList();
            foreach (Empleados emp in emps)
            {
                //Response.Write(emp.Nombre);
                //Response.Write("<BR>");
            }

            /*List<Genero> generos = contexto.Genero.ToList();
            foreach (Genero gen in generos)
            {
                Response.Write(gen.Descripcion);
                Response.Write("<BR>");
            }*/
            Response.Write("Fin");
            fin = DateTime.Now;
            Response.Write("<BR>");
            Response.Write(principio.ToString());
            Response.Write("<BR>");
            Response.Write(fin.ToString());
            Response.Write("<BR>");
            Response.Write((fin - principio).ToString());

        }
    }
}