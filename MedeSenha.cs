using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

/// <summary>
/// Summary description for MedeSenha
/// </summary>
public class MedeSenha
{
    public MedeSenha()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public void medeSenha(string senha, int medidor)
    {
        if (senha.Length < 6 || senha.Length > 12)
        {
            medidor = medidor - 1;
            HttpContext.Current.Response.Write("Senha precisa de 6 a 12 caracteres !");

            if (!senha.Any(c => char.IsUpper(c)))
            {
                medidor = medidor - 1;
                HttpContext.Current.Response.Write("Senha precisa de ao menos 1 letra maiúscula !");

                if (!senha.Any(c => char.IsDigit(c)))
                {
                    medidor = medidor - 1;
                    HttpContext.Current.Response.Write("Senha precisa de ao menos 1 número !");
                }            
            }
        }

        else if (!senha.Any(c => char.IsDigit(c)))
        {
            medidor = medidor - 1;
            HttpContext.Current.Response.Write("Senha precisa de ao menos 1 número !");

            if (!senha.Any(c => char.IsUpper(c)))
            {
                medidor = medidor - 1;
                HttpContext.Current.Response.Write("Senha precisa de ao menos 1 letra maiúscula !");

                if (senha.Length < 6 || senha.Length > 12)
                {
                    medidor = medidor - 1;
                    HttpContext.Current.Response.Write("Senha precisa de 6 a 12 caracteres !");
                }
            }
        }

        else if (!senha.Any(c => char.IsUpper(c)))
        {
            medidor = medidor - 1;
            HttpContext.Current.Response.Write("Senha precisa de ao menos 1 letra maiúscula !");

            if (senha.Length < 6 || senha.Length > 12)
            {
                medidor = medidor - 1;
                HttpContext.Current.Response.Write("Senha precisa de 6 a 12 caracteres !");

                if (!senha.Any(c => char.IsDigit(c)))
                {
                    medidor = medidor - 1;
                    HttpContext.Current.Response.Write("Senha precisa de ao menos 1 número !");
                }
            }
        }
    }
}