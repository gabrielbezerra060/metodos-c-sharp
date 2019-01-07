using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TESTE : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void confirmaSenha_Click(object sender, EventArgs e)
    {
        int teste = 3;
        MedeSenha ms = new MedeSenha();
        ms.medeSenha(senha.Value, teste);
         

    }
}