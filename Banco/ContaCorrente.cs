using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;
public class ContaCorrente
{
    public string nome;
    public int agencia;
    public string conta;
    public double saldo;
    public void sacar(double valor)
    {
        this.saldo -= valor;
    }
}