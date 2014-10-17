﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections;


namespace MuseoCliente.Connection.Objects
{
    class Pieza: ResourceObject<Pieza>
    {
        [JsonProperty]
        public String codigo { get; set; }
        [JsonProperty]
        public String codigoSlug { get; set; }
        [JsonProperty]
        public int clasificacion { get; set; }
        [JsonProperty]
        public int autor {get;set;}
        [JsonProperty]
        public int responsableRegistro {get;set;}
        [JsonProperty]
        public Boolean registroIDAEH { get; set; }
        [JsonProperty]
        public String codigoIDAEH { get; set; }
        [JsonProperty]
        public String archivoIDAEH { get; set; }
        [JsonProperty]
        public String nombre { get; set; }
        [JsonProperty]
        public String descripcion { get; set; }
        [JsonProperty]
        public DateTime fechaIngreso { get; set; }
        [JsonProperty]
        public String procedencia { get; set; }
        [JsonProperty]
        public int pais { get; set; }
        [JsonProperty]
        public Int16 regionCultural { get; set; }
        [JsonProperty]
        public String observaciones { get; set; }
        [JsonProperty]
        public Boolean maestra { get; set; }
        [JsonProperty]
        public Boolean exhibicion { get; set; }
        [JsonProperty]
        public float altura { get; set; }
        [JsonProperty]
        public float ancho { get; set; }
        [JsonProperty]
        public float grosor { get; set; }
        [JsonProperty]
        public float largo { get; set; }
        [JsonProperty]
        public float diametro { get; set; }


        public Pieza()
            : base("we/ewa/s")
        {
        }

		public void guardar()
		{
			try
			{
				this.Create();
			}
			catch( Exception e)
			{
				if (e.Source != null)
                {
                    string error = e.Source; // para ver el nombre del error.
					Error.ingresarError(3,"No se ha guardado en la Informacion en la base de datos");
                }
			}
		}
		
		public void modificar(int id)
		{
			try
			{
				this.Save(id);
			}
			catch( Exception e)
			{
				if (e.Source != null)
                {
                    string error = e.Source;// para ver el nombre del error
					Error.ingresarError(3,"No se ha modifico en la Informacion en la base de datos");
                }
			}		
		}
			
		
        public ArrayList consultarNombre(String nombre)
        {
			try{
				
				List<Pieza> lista = null;
				List<Pieza> listaNueva = new List<Pieza>();
				lista = this.GetAsCollection();	
				foreach(Pieza pieza in lista)
				{
						if(pieza.nombre.Contains(nombre))
							listaNueva.Add(pieza);
				}
                if(listaNueva == null)
                    Error.ingresarError(2, "No se encontro nombre similares");
			}catch(Exception e)
			{
				Error.ingresarError(2,"No se encontro nombre similares");
			}
			
            return new ArrayList(listaNueva);
        }

        public ArrayList consultarCodigo(String codigo)
        {
            try
            {

                List<Pieza> lista = null;
                List<Pieza> listaNueva = new List<Pieza>();
                lista = this.GetAsCollection();
                foreach (Pieza pieza in lista)
                {
                    if (pieza.codigo.Contains(codigo))
                        listaNueva.Add(pieza);
                }
                if (listaNueva == null)
                    Error.ingresarError(2, "No se encontro nombre similares");
            }
            catch (Exception e)
            {
                Error.ingresarError(2, "No se encontro nombre similares");
            }

            return new ArrayList(listaNueva);
        }

        public ArrayList consultarClasificacion(int idClasificacion)
        {
            try
            {

                List<Pieza> lista = null;
                List<Pieza> listaNueva = new List<Pieza>();
                lista = this.GetAsCollection();
                foreach (Pieza pieza in lista)
                {
                    if (pieza.codigo.clasificacion = idClasificacion)
                        listaNueva.Add(pieza);
                }
                if (listaNueva == null)
                    Error.ingresarError(2, "No se encontro nombre similares");
            }
            catch (Exception e)
            {
                Error.ingresarError(2, "No se encontro nombre similares");
            }

            return new ArrayList(listaNueva);
        }

        public ArrayList consultarAutor(int idAutor)
        {
            try
            {

                List<Pieza> lista = null;
                List<Pieza> listaNueva = new List<Pieza>();
                lista = this.GetAsCollection();
                foreach (Pieza pieza in lista)
                {
                    if (pieza.codigo.autor = idAutor)
                        listaNueva.Add(pieza);
                }
                if (listaNueva == null)
                    Error.ingresarError(2, "No se encontro nombre similares");
            }
            catch (Exception e)
            {
                Error.ingresarError(2, "No se encontro nombre similares");
            }

            return new ArrayList(listaNueva);
        }

    }
}
