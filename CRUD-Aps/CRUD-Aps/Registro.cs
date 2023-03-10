namespace CRUD_Aps
{
    class Registro
    {
        public int IdRegistro { get; set; }
        public string dataRegistro { get; set; }
        public string nomeFiscal { get; set; }
        public string Crime { get; set; }
        public string regiao { get; set; }

        public Registro()
        {

        }

        public Registro(int id, string data, string fiscal, string crime, string regiao)
        {
            this.IdRegistro = id;
            this.nomeFiscal = fiscal;
            this.dataRegistro = data;
            this.Crime = crime;
            this.regiao = regiao;
        }

        public string msg { get; set; }
        public string Status { get; set; }
    }
}
