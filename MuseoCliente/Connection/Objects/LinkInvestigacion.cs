﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Collections;

namespace MuseoCliente.Connection.Objects
{
    public class LinkInvestigacion:ResourceObject<LinkInvestigacion>
    {
        public LinkInvestigacion():base("v1/linkInvestigacion/")
        {

        }
        
        [JsonProperty]
        public string link { get; set; }

        public void guardar()
        {
            try
            {
                this.Create();
            }
            catch (Exception e)
            {
                if (e.Source != null)
                {
                    Error.ingresarError(3, "No se ha guardado la Informacion en la base de datos");
                }
            }
        }

        public void modificar(string id)
        {
            try
            {
                this.Save(id);
            }
            catch (Exception e)
            {
                if (e.Source != null)
                {
                    Error.ingresarError(4, "No se ha modificado la Informacion en la base de datos");
                }
            }
        }

        public ArrayList consultarLink(string link)
        {
            List<LinkInvestigacion> listaNueva = new List<LinkInvestigacion>();
            try
            {
                List<LinkInvestigacion> todasPiezas = this.GetAsCollection();
                foreach (LinkInvestigacion Link in todasPiezas)
                {
                    if (Link.link.Contains(link))
                        listaNueva.Add(Link);
                }
                if (listaNueva == null)
                    Error.ingresarError(2, "no se encontraron coincidencias con link: " + link);
            }
            catch (Exception e)
            {
                Error.ingresarError(2, "no se encontraron coincidencias con link: " + link);
            }
            return new ArrayList(listaNueva);
        }

    }
}
