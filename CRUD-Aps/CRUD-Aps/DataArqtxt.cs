using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Aps
{
    class DataArqtxt
    {
        Registro auxRegistro = null;
        public List<Registro> SelectRegistros(Arquivo auxArquivo)
        {
            List<Registro> auxListRegistro = new List<Registro>();

            string[] Registros, campos;

            Registros = auxArquivo.ConteudoArq.Split(';');

            for (int i = 0; i < Registros.Length - 1; i++)
            {
                auxRegistro = new Registro();

                campos = Registros[i].Split(',');
                auxRegistro.IdRegistro = Convert.ToInt32(campos[0]);
                auxRegistro.dataRegistro = campos[1];
                auxRegistro.nomeFiscal = campos[2];
                auxRegistro.Crime = campos[3];
                auxRegistro.regiao = campos[4];

                auxListRegistro.Add(auxRegistro);

            }
            return auxListRegistro;
        }
        public List<Registro> BucketSort(List<Registro> auxRegistro, int quantidade)
        {
            List<Registro>[] Buckets = new List<Registro>[quantidade];
            List<Registro> Ordenadobucket = new List<Registro>();
            Registro auxReg = null;

            for (int i = 0; i < quantidade; i++)
            {
                Buckets[i] = new List<Registro>();
            }
            for (int i = 0; i < quantidade; i++)
            {

                auxReg = new Registro();

                auxReg.IdRegistro = auxRegistro[i].IdRegistro;
                auxReg.dataRegistro = auxRegistro[i].dataRegistro;
                auxReg.nomeFiscal = auxRegistro[i].nomeFiscal;
                auxReg.Crime = auxRegistro[i].Crime;
                auxReg.regiao = auxRegistro[i].regiao;

                float idx = (auxReg.IdRegistro / 10);
                Buckets[(int)idx].Add(auxReg);
            }
            
            for (int i = 0; i < quantidade / 10; i++)
            {
                List<Registro> bucketdesordenado = new List<Registro>();

                while (Buckets[i].Count >= 1)
                {
                    bucketdesordenado.Add(this.MenorRegistro(Buckets[i]));
                }
                Buckets[i] = bucketdesordenado;
            }

            for (int i = 0; i < quantidade; i++)
            {
                for (int j = 0; j < Buckets[i].Count; j++)
                {
                    Ordenadobucket.Add(Buckets[i][j]);
                }
            }


            return Ordenadobucket;
        }

        public Registro MenorRegistro(List<Registro> auxRegistro)
        {
            Registro menor = new Registro();
            menor = auxRegistro[0];
            int index = 0;

            for (int i = 0; i < auxRegistro.Count; i++)
            {
                if (auxRegistro[i].IdRegistro < menor.IdRegistro && auxRegistro[i].IdRegistro >= 1)
                {
                    menor = auxRegistro[i];
                    index = i;
                }
            }
            auxRegistro.RemoveAt(index);
            menor.Status = "OK";
            return menor;
        }
        public List<Registro> DesordenaRegistros(List<Registro> auxRegistro)
        {
            List<Registro> auxRetRegis = new List<Registro>();
            Random numeroaleatório = new Random();
            while (auxRegistro.Count > 0)
            {
                int numero = numeroaleatório.Next(0, auxRegistro.Count);

                auxRetRegis.Add(auxRegistro[numero]);
                auxRegistro.RemoveAt(numero);
            }
            return auxRetRegis;
        }
        public List<Registro> InsertionSort(List<Registro> auxRegistro)
        {
            Registro val = null;
            int flag;
            for (int i = 1; i < auxRegistro.Count; i++)
            {
                val = auxRegistro[i];

                flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val.IdRegistro < auxRegistro[j].IdRegistro)
                    {
                        auxRegistro[j + 1] = auxRegistro[j];
                        j--;
                        auxRegistro[j + 1] = val;
                    }
                    else flag = 1;
                }
            }

            return auxRegistro;
        }

        public List<Registro> SelectionSort(List<Registro> auxRegistro)
        {

            Registro temp = null;
            int Smallest;

            for (int i = 0; i < auxRegistro.Count - 1; i++)
            {
                temp = new Registro();
                Smallest = i;

                for (int j = i + 1; j < auxRegistro.Count; j++)
                {
                    if (auxRegistro[j].IdRegistro < auxRegistro[Smallest].IdRegistro)
                    {
                        Smallest = j;
                    }

                }
                temp = auxRegistro[Smallest];
                auxRegistro[Smallest] = auxRegistro[i];
                auxRegistro[i] = temp;
            }

            return auxRegistro;
        }

        public void CreateArquivo(Arquivo auxArquivo)
        {
            try
            {
                TextWriter Local = new StreamWriter(auxArquivo.LocalArquivo, true, Encoding.UTF8);

                for (int i = 0; i < auxArquivo.conteudo.Length; i++)
                {
                    Local.WriteLine(auxArquivo.conteudo[i]);
                }
                Local.Close();
                auxArquivo.Status = "OK";
            }
            catch (Exception ex)
            {
                auxArquivo.Status = "NOK";
                auxArquivo.msg = ex.ToString();
            }
        }

        public void ArqLog(Arquivo auxArquivo, List<Registro> orderRegistros)
        {
            try
            {
                string[] foulder = auxArquivo.LocalArquivo.Split((char)92);
                string local = string.Empty;

                for (int i = 0; i < foulder.Length - 1; i++)
                {
                    local = local + foulder[i] + (char)92;
                }
                local = local + "Order" + auxArquivo.NomeArquivo + ".log";

                if (File.Exists(local))
                {
                    TextReader LocalGetExist = new StreamReader(local);
                    LocalGetExist.Close();

                    TextWriter SetLocalExist = new StreamWriter(local, true, Encoding.UTF8);

                    SetLocalExist.WriteLine("=====================================");
                    SetLocalExist.WriteLine(auxArquivo.NomeArquivo + " metod:");
                    SetLocalExist.WriteLine("Type Arq Extract: " + auxArquivo.tipo);
                    SetLocalExist.WriteLine("Num Regist: " + orderRegistros.Count);
                    SetLocalExist.WriteLine("Date : " + DateTime.Now.ToString("dd/MM/yyyy") + " Hours: " + DateTime.Now.ToString("HH:mm"));
                    SetLocalExist.WriteLine("Execution Time: " + auxArquivo.msg);
                    SetLocalExist.Close();
                }
                else
                {
                    TextWriter SetLocalExist = new StreamWriter(local, true, Encoding.UTF8);

                    SetLocalExist.WriteLine(auxArquivo.ConteudoArq);
                    SetLocalExist.WriteLine("=====================================");
                    SetLocalExist.WriteLine("Type Arq Extract: " + auxArquivo.tipo);
                    SetLocalExist.WriteLine(auxArquivo.NomeArquivo + " metod:");
                    SetLocalExist.WriteLine("Num Regist: " + orderRegistros.Count);
                    SetLocalExist.WriteLine("Date : " + DateTime.Now.ToString("dd/mm/yyyy") + " Hours: " + DateTime.Now.ToString("HH:mm"));
                    SetLocalExist.WriteLine("Execution Time: " + auxArquivo.msg);
                    SetLocalExist.Close();
                }
            }
            catch (Exception ex)
            {
                auxArquivo.Status = "NOK";
                auxArquivo.msg = ex.ToString();
            }
        }

    }
}
