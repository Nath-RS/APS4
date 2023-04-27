using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Aps
{
    class RegraNegocio
    {
        Arquivo AuxRetArquivo = null;
        List<Registro> auxRegistros = new List<Registro>();
        DataArqtxt auxDataArqtxt = new DataArqtxt();
        public List<Registro> SelectRegistros(Arquivo auxArquivo)
        {
            auxRegistros.Clear();
            AuxRetArquivo = new Arquivo();
            try
            {
                if (File.Exists(auxArquivo.LocalArquivo))
                {
                    TextReader Local = new StreamReader(auxArquivo.LocalArquivo);
                    AuxRetArquivo.ConteudoArq = Local.ReadToEnd();
                    Local.Close();
                    auxRegistros = auxDataArqtxt.SelectRegistros(AuxRetArquivo);
                    auxRegistros[0].Status = "OK";
                    auxArquivo.Status = "OK";
                }
                else
                {
                    MessageBox.Show("O arquivo Selecionado não existe ou caminho incorreto", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return auxRegistros;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                auxArquivo.Status = "NOK";
                MessageBox.Show("O Programa não reconheceu nenhum Registro dentro do arquivo", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return auxRegistros;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return auxRegistros;
            }
            
        }

        public List<Registro> OrdenarBucketsRegistros(List<Registro> auxlisRegis,int quantidade)
        {
            List<Registro> Ordenado = new List<Registro>();
            try
            {
                Ordenado = auxDataArqtxt.BucketSort(auxlisRegis, quantidade);
                Ordenado[0].Status = "OK";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "BucketSort:ERRO !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ordenado[0].Status = "NOK";
            }
            return Ordenado;
        }

        public List<Registro> DesordenaRegistros(List<Registro> auxlisRegis)
        {
            List<Registro> Desordenado = new List<Registro>();
            try
            {
                    Desordenado = auxDataArqtxt.DesordenaRegistros(auxlisRegis);   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERRO !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Desordenado;
        }

        public List<Registro> OrdenarInsertionRegistros(List<Registro> auxlisRegis)
        {
            try
            {
                auxlisRegis = auxDataArqtxt.InsertionSort(auxlisRegis);
                auxlisRegis[0].Status = "OK";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "InsertionSort:ERRO !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auxlisRegis[0].Status = "NOK";
            }
            return auxlisRegis;
        }

        public List<Registro> OrdenarSelectionRegistros(List<Registro> auxlisRegis)
        {
            try
            {
                auxlisRegis = auxDataArqtxt.SelectionSort(auxlisRegis);
                auxlisRegis[0].Status = "OK";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SelectionSort:ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                auxlisRegis[0].Status = "NOK";
            }
            return auxlisRegis;
        }

        public void OrdenaArqlog (Arquivo auxArquivo,List<Registro> auxlisRegis)
        {
            auxDataArqtxt.ArqLog(auxArquivo, auxlisRegis);
        }

        public void SaveArquivotxt(Arquivo auxArquivo)
        {
            auxDataArqtxt.CreateArquivo(auxArquivo);
        }
    }
}
