using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using proyectoWebApi.CSD;
using RestSharp;
using System.Drawing;

namespace proyectoWebApi.Cusuario
{
    public partial class consultausuario : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bconsultar_Click(object sender, EventArgs e)
        {

            RestClient client = new RestClient("https://randomuser.me/api/");
            string respuesta;

            RestRequest request = new RestRequest();

            var response = client.Get(request);

            respuesta = response.Content;

            resultados oresultado= JsonConvert.DeserializeObject<resultados>(respuesta);

            usuario ousuario = oresultado.results[0];

            imgusuario.ImageUrl = ousuario.picture.large;
            txttitulo.Text = ousuario.name.tittle;
            txtnombre.Text = ousuario.name.first;
            txtapellidos.Text = ousuario.name.last;
            txtusuario.Text = ousuario.login.username;
            txtcontrasena.Text = ousuario.login.password;

        }
    }
}