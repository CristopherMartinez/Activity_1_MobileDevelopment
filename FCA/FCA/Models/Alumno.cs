using System;
using SQLite;

namespace FCA.Models
{
	public class Alumno
	{
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

		public string Nombre { get; set; }

		public string ApellidoPat { get; set; }

        public string ApellidoMat { get; set; }

        public string Correo { get; set; }

		public string Celular { get; set; }


	}
}

