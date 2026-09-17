using System.Collections.Generic;
using System.Web.Http;
using apiRESTCensoTads.Models;

namespace apiRESTCensoTads.Controllers
{
    public class CensoController : ApiController
    {
        public static clsCenso[] objCenso = null;

        // GET: api/Censo
        [HttpGet]
        public IEnumerable<clsCenso> Get()
        {
            if (objCenso == null)
            {
                return new clsCenso[0];
            }

            return objCenso;
        }

        // GET: api/Censo/3
        [HttpGet]
        public clsCenso Get(int id)
        {
            if (objCenso != null)
            {
                for (int i = 0; i < objCenso.Length; i++)
                {
                    if (objCenso[i] != null && objCenso[i].id == id)
                    {
                        return objCenso[i];
                    }
                }
            }

            return new clsCenso();
        }

        // POST: api/Censo?posicion=0
        [HttpPost]
        public string Post(int posicion, [FromBody] clsCenso modelo)
        {
            if (modelo == null)
            {
                return "0";
            }

            if (objCenso == null)
            {
                objCenso = new clsCenso[5];

                for (int i = 0; i < objCenso.Length; i++)
                {
                    objCenso[i] = new clsCenso();
                }
            }

            if (posicion < 0 || posicion >= objCenso.Length)
            {
                return "0";
            }

            objCenso[posicion].id = modelo.id;
            objCenso[posicion].curp = modelo.curp;
            objCenso[posicion].nombre = modelo.nombre;
            objCenso[posicion].apellidoPaterno = modelo.apellidoPaterno;
            objCenso[posicion].apellidoMaterno = modelo.apellidoMaterno;
            objCenso[posicion].direccion = modelo.direccion;
            objCenso[posicion].actividadEconomica = modelo.actividadEconomica;

            return "1";
        }

        // PUT: api/Censo?posicion=0
        [HttpPut]
        public string Put(int posicion, [FromBody] clsCenso modelo)
        {
            if (objCenso == null)
            {
                return "-1";
            }

            if (modelo == null)
            {
                return "0";
            }

            if (posicion < 0 || posicion >= objCenso.Length)
            {
                return "0";
            }

            objCenso[posicion].id = modelo.id;
            objCenso[posicion].curp = modelo.curp;
            objCenso[posicion].nombre = modelo.nombre;
            objCenso[posicion].apellidoPaterno = modelo.apellidoPaterno;
            objCenso[posicion].apellidoMaterno = modelo.apellidoMaterno;
            objCenso[posicion].direccion = modelo.direccion;
            objCenso[posicion].actividadEconomica = modelo.actividadEconomica;

            return "1";
        }

        // DELETE: api/Censo?posicion=0
        [HttpDelete]
        public string Delete(int posicion)
        {
            if (objCenso == null)
            {
                return "-1";
            }

            if (posicion < 0 || posicion >= objCenso.Length)
            {
                return "0";
            }

            objCenso[posicion].id = 0;
            objCenso[posicion].curp = null;
            objCenso[posicion].nombre = null;
            objCenso[posicion].apellidoPaterno = null;
            objCenso[posicion].apellidoMaterno = null;
            objCenso[posicion].direccion = null;
            objCenso[posicion].actividadEconomica = null;

            return "1";
        }
    }
}