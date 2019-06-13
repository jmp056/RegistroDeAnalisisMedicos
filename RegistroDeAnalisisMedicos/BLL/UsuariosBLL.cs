﻿using RegistroDeAnalisisMedicos.DAL;
using RegistroDeAnalisisMedicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAnalisisMedicos.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Usuarios.Add(usuario) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Usuarios usuario)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(usuario).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Usuarios.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Usuarios Buscar(int id)
        {
            Contexto db = new Contexto();
            Usuarios usuario = new Usuarios();
            try
            {
                usuario = db.Usuarios.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return usuario;
        }

        public static bool Existe(string telefono)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Usuarios.Any(p => p.Telefono.Equals(telefono)))
                    paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;

        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> usuario)
        {
            List<Usuarios> Lista = new List<Usuarios>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Usuarios.Where(usuario).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
