using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QixyPro.Models;
namespace QixyPro.IRespo
{
   public interface IHotel
   {
        List<HotelModel> getHotel();
        string insert(HotelModel s);
        string Delete(int Det);
      //string Edit(HotelModel s);
        Reservation getID(int s);
   }

    class HotelIc : IHotel
    {
        List<HotelModel> IHotel.getHotel()
        {
            quixyEntities sk = new quixyEntities();
            List<HotelModel> Hotellist = sk.Reservations.Select(s=>new HotelModel()
            {
                Sno=s.Sno,
                Hotel=s.Hotel,
                Arrival=s.Arrival,
                Departure=s.Departure,
                Types=s.Types,
                Guests=s.Guests,
                price=s.price
            }).ToList<HotelModel>();
            return Hotellist;
        }
       
        
        string IHotel.insert(HotelModel s)
        {
            //try
            //{
                quixyEntities sk = new quixyEntities();
                var shiva = sk.Reservations.Where(f => f.Sno == s.Sno).FirstOrDefault();
                if (shiva == null)
                {
                    sk.Reservations.Add(new Reservation
                    {
                        Sno = s.Sno,
                        Hotel = s.Hotel,
                        Arrival = s.Arrival,
                        Departure = s.Departure,
                        Types = s.Types,
                        Guests = s.Guests,
                        price=s.price

                    });
                    sk.SaveChanges();
                    sk.Dispose();
                    return "inserted";

                }
                else
                {
                        shiva.Sno = s.Sno;
                        shiva.Hotel = s.Hotel;
                        shiva.Arrival = s.Arrival;
                        shiva.Departure = s.Departure;
                        shiva.Types = s.Types;
                        shiva.Guests = s.Guests;
                        shiva.price = s.price;

                    
                }
                sk.SaveChanges();
                sk.Dispose();
                return "update";

           // }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("error occred",ex);
            //}
            //return "not";
            
        }
        
        
        string IHotel.Delete(int Det)
        {
            quixyEntities sk = new quixyEntities();

            var kohli = sk.Reservations.Where(u => u.Sno == Det).FirstOrDefault();
            if (kohli != null)
            {
                sk.Reservations.Remove(kohli);
                sk.SaveChanges();
            }

            return "Delete"; ;
        }
        /*
        string IHotel.Edit(HotelModel s)
        {
            quixyEntities vk = new quixyEntities();
            var shiva = vk.Reservations.Where(u => u.Sno == s.Sno).FirstOrDefault();
            if (shiva != null)
            {

                shiva.Sno = s.Sno;
                shiva.Hotel = s.Hotel;
                shiva.Arrival = s.Arrival;
                shiva.Departure = s.Departure;
                shiva.Types = s.Types;
                shiva.Guests = s.Guests;
                shiva.price = s.price;
            }
            vk.SaveChanges();
            vk.Dispose();
            return "update";
        }*/

        Reservation IHotel.getID(int s)
        {
            quixyEntities sk = new quixyEntities();
            if (s != 0)
            {
                var v = sk.Reservations.Where(z => z.Sno == s).FirstOrDefault();
                sk.Dispose();
                return v;
            }
            return null;
        }
    }
}
