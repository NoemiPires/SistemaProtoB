using System;
using Microsoft.EntityFrameworkCore;

namespace SistemaProtoB
{
    internal class IngressoRepository
    {
        public static void Save(Ingresso ingresso)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (ingresso.Id == 0)
                    {
                        dbContext.Ingressos.Add(ingresso);
                    }
                    else
                    {
                        dbContext.Entry.(ingresso).State = EntityState.Modified;
                    }
                    dbContext.SaveChanges();
                }
            
            }
            catch {Exception}
            {
                throw;
            }
        }



    }
}
