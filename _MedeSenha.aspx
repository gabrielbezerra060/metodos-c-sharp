<%@ Page Language="C#" AutoEventWireup="true" CodeFile="_MedeSenha.aspx.cs" Inherits="TESTE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link href="CSS.css" rel="stylesheet" />

    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <input id="senha" runat="server" type="password" placeholder="Senha"/>
     <asp:Button id="botao" runat="server" text="Confirmar" OnClick="confirmaSenha_Click"/>
    </div>
    </form>
</body>

</html>
