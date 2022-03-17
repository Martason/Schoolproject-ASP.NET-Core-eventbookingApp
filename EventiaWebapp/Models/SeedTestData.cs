﻿using EventiaWebapp.Services.Data;
using Microsoft.EntityFrameworkCore;

namespace EventiaWebapp.Models
{
    public class SeedTestData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            // new EpicEventsContext(
            //     serviceProvider.GetRequiredService<
            //         DbContextOptions<EpicEventsContext>>()))
            

            using (var context = serviceProvider.GetRequiredService<EpicEventsContext>())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                // // Från msdn
                // if (context.Movie.Any())
                // {
                //     return;   // DB has been seeded
                // }

                var attendes = new List<Attendee>
                {
                    new Attendee{Name = "Märta Hjalmarson", Email = "marta@hotmail.com"},
                    new Attendee{ Name = "Pia Hagman", Email = "pia@hotmail.com"
                }
                };

                context.AddRange(attendes);
                context.SaveChanges();

                var organizers = new List<Organizer>
                {
                    new Organizer{Name = "Boardgames AB", Email = "info@boardgame.se"},
                    new Organizer{Name = "GymBeast AB", Email = "info@gymbeast.se"},
                    new Organizer{Name = "Wine Explorer AB", Email = "info@wineexplorer.se"}

                };

                context.AddRange(organizers);
                context.SaveChanges();

                var events = new List<Event>
                {
                    new Event {Title = "Eclipse Event", Date = new DateTime(2022,06,15), Place = "Göteborg", Adress = "Föreningsgatan 14, 411 28 Göteborg", SpotsAvalable = 6,
                        Organizer = organizers[0], InfoLong = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful"
                    },
                    new Event {Title = "Small World Event", Date = new DateTime(2022,07,15), Place = "Göteborg", Adress = "Föreningsgatan 14, 411 28 Göteborg", SpotsAvalable = 6,
                        Organizer = organizers[0], InfoLong = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful"
                    },
                    new Event {Title = "Terraforming Mars", Date = new DateTime(2022,08,15), Place = "Göteborg", Adress = "Föreningsgatan 14, 411 28 Göteborg", SpotsAvalable = 6,
                        Organizer = organizers[0],InfoLong = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful"
                    },
                    new Event {Title = "Gym challange", Date = new DateTime(2022,09,15), Place = "Göteborg", Adress = "Föreningsgatan 14, 411 28 Göteborg", SpotsAvalable = 6,
                        Organizer = organizers[1],InfoLong = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful"
                    },
                    new Event {Title = "Bodypump", Date = new DateTime(2022,04,15), Place = "Göteborg", Adress = "Föreningsgatan 14, 411 28 Göteborg", SpotsAvalable = 15,
                        Organizer = organizers[1],InfoLong = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful"
                    },
                    new Event {Title = "Göteborgsvarvet", Date = new DateTime(2022,05,15), Place = "Göteborg", Adress = "Föreningsgatan 14, 411 28 Göteborg", SpotsAvalable = 15,
                        Organizer = organizers[1],InfoLong = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful"
                    },
                    new Event {Title = "Riesling tasting", Date = new DateTime(2022,06,15), Place = "Göteborg", Adress = "Föreningsgatan 14, 411 28 Göteborg", SpotsAvalable = 15,
                        Organizer = organizers[2],InfoLong = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful"
                    },
                    new Event {Title = "Cabernet Souvigion tasting", Date = new DateTime(2022,06,15), Place = "Göteborg", Adress = "Föreningsgatan 14, 411 28 Göteborg", SpotsAvalable = 15,
                        Organizer = organizers[2],InfoLong = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful"
                    },
                    new Event {Title = "Zinfandel tasting", Date = new DateTime(2022,06,15), Place = "Göteborg", Adress = "Föreningsgatan 14, 411 28 Göteborg", SpotsAvalable = 15,
                        Organizer = organizers[2],InfoLong = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful"
                    },

                };

                context.AddRange(events);
                context.SaveChanges();



            }

        }
    }
}
