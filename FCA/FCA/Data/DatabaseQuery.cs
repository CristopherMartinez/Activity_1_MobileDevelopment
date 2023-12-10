using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FCA.Models;
using SQLite;

namespace FCA.Data
{
	public class DatabaseQuery
	{

        private readonly SQLiteAsyncConnection database;

        public DatabaseQuery(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            //La siguiente linea de codigo se ejecuta siempre y
            //cuando no se cuente con la tabla
            //Si en dado caso ya existe se salta esta linea de codigo
            database.CreateTableAsync<Alumno>().Wait();
        }



        //La palabra Task se refiere a una tarea como parte de las funciones que se puede
        //ejecutar en SQlite
        public Task<List<Alumno>> GetAlumnos()
        {
            return database.QueryAsync<Alumno>("SELECT * FROM Alumno");
        }


        //El siguiente me tomamos un objeto y con ello almacenamos los
        //datos de un determinado alumno
        //Tiene un valor de tipo int como retorno siendo la nueva clase o id principal
        public Task<int> SaveAlumnoAsync(Alumno alumno)
        {
            if (alumno.Id != 0)
            {
                return database.UpdateAsync(alumno);
            }
            else
            {
                return database.InsertAsync(alumno);
            }

        }


        //Funcion para borrar usuario
        public Task<int> DeleteAlumnoAsync(Alumno alumno)
        {
            return database.DeleteAsync(alumno);
        }


        //Funcion para obtener la lista de usuarios
        public Task<List<Alumno>> GetAlumnosAsync()
        {
            return database.Table<Alumno>().ToListAsync();
        }



        //Funcion para obtener usuario mediante id
        public Task<Alumno> GetAlumnobyID(int idAlumno)
        {
            return database.Table<Alumno>().Where(a => a.Id == idAlumno).FirstOrDefaultAsync();

        }

        //Funcion para actualizar alumno
        public Task<int> UpdateAlumno(Alumno a)
        {
            return database.UpdateAsync(a);
        }


        //Funcion para borrar Alumno
        public Task<int> DeleteAlumno(Alumno a)
        {
            return database.DeleteAsync(a);
        }

        //Funcion de consulta de alumnos con consulta de sql
        public Task<List<Alumno>> Consulta_alumnos()
        {
            return database.QueryAsync<Alumno>("SELECT * FROM Alumnos");
        }



    }
}

