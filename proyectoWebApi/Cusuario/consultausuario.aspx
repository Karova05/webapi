<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consultausuario.aspx.cs" Inherits="proyectoWebApi.Cusuario.consultausuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Image ID="imgusuario" runat="server"  ImageUrl="https://randomuser.me/api/"/>
            

            </div>

            <div>   

            <asp:Label ID="Label1" runat="server" Text="titulo"></asp:Label><asp:TextBox ID="txttitulo" runat="server" ></asp:TextBox>
             <br />
                <br />
                <br />
            <asp:Label runat="server" Text="nombre" ID="ctl00"></asp:Label><asp:TextBox runat="server" ID="txtnombre"></asp:TextBox>

                <br />
   <br />
   <br />
                <asp:Label runat="server" Text="apellidos" ID="ctl09"></asp:Label><asp:TextBox runat="server" ID="txtapellidos"></asp:TextBox>
                <br />
<br />

                <asp:Label ID="Label2" runat="server" Text="usuario"></asp:Label><asp:TextBox ID="txtusuario" runat="server" ></asp:TextBox>
                <br />
<br />

                <asp:Label ID="Label3" runat="server" Text="contrasena"></asp:Label><asp:TextBox ID="txtcontrasena" runat="server"></asp:TextBox>

                                <br />
<br />

                <asp:Button ID="bconsultar" runat="server" Text="consultar" OnClick="bconsultar_Click" />
        </div>
                           
    </form>
</body>
</html>
