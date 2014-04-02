namespace DotNetFloripa.Data.Migrations
{
    using DotNetFloripa.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DotNetFloripa.Data.DotNetFloripaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DotNetFloripa.Data.DotNetFloripaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            context.Events.AddOrUpdate(new Event {
                    Slug = "dotnetfloripa-fevereiro",
                    Description = "O grupo DotNetFloripa est� voltando a ativa e j� temos um novo evento marcado!",
                    Start = new DateTime(2014,2,19,19,00,0),
                    End = new DateTime(2014,2,19,21,30,0),
                    EventickId = 4846,
                    EventickUrl = "http://www.eventick.com.br/dotnetfloripa-fevereiro",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[]{"Andr� Carlucci", "Renato Haddad", "Lu�s Deschamps Rudge"},
                    Title = "dotnet Floripa - Fevereiro",
                    Talks = new[]{ 
                        new Talk { 
                            Description = "NancyFX � um framework HTTP super leve que serve de alternativa para o ASP.NET MVC ou ASP.NET Web API. Por que precisamos de uma alternativa? Quais os benef�cios que isso traz e como introduzir o NancyFX em um app j� existente? Venha conferir!",
                            Start = new DateTime(2014,2,19,19,30,0),
                            End = new DateTime(2014,2,19,20,15,0),
                            Speaker = "Lu�s Deschamps Rudge",
                            Title = "Conhe�a o NancyFX!"
                        },new Talk { 
                            Start = new DateTime(2014,2,19,20,15,0),
                            End = new DateTime(2014,2,19,20,30,0),
                            Title = "coffee-break",
                            Description = "Sim! Agora temos coffee-break com deliciosos salgadinhos!"
                        },new Talk { 
                            Description = "Todos n�s amamos o Nuget. � at� dif�cil lembrar o quanto era cruel gerenciar nossas depend�ncias de projetos manualmente. Nesta palestra damos um passo a mais: vamos aprender como criar nossos pr�prios pacotes, integr�-los com builds automatizados e descobrir como sua empresa pode tirar o m�ximo desta tecnologia.",
                            Start = new DateTime(2014,2,19,20,30,0),
                            End = new DateTime(2014,2,19,21,30,0),
                            Speaker = "Andr� Carlucci",
                            Title = "Aproveite ao m�ximo o Nuget"
                        }
                    }
                }
            );

            context.Events.AddOrUpdate(new Event {
                    Id = 2,
                    Slug = "gwab-floripa",
                    Description = "Bootcamp de Windows Azure! Mais informa��es no <a href='http://gwab2014-floripa.azurewebsites.net/'>site oficial</a>! ",
                    Start = new DateTime(2014,3,29,8,0,0),
                    End = new DateTime(2014,3,29,17,0,0),
                    EventickId = 0,
                    EventickUrl = "http://www.eventick.com.br/GWAB2014-Florianopolis-SC",
                    ImageUrl = "http://i.imgur.com/yW4p5Yy.jpg",
                    Organizers = new[]{"Andr� Carlucci", "Lu�s Deschamps Rudge"},
                    Title = "Global Windows Azure Bootcamp - Floripa",
                    Talks = new[]{ 
                        new Talk { 
                            Description = "Boas vindas",
                            Start = new DateTime(2014,3,29,8,0,0),
                            End = new DateTime(2014,3,29,8,30,0),
                            Speaker = "-",
                            Title = "Welcome"
                        },new Talk { 
                            Description = "Keynote sobre o evento",
                            Start = new DateTime(2014,3,29,8,30,0),
                            End = new DateTime(2014,3,29,9,0,0),
                            Speaker = "-",
                            Title = "Keynote Microsoft"
                        },new Talk { 
                            Description = "Overview sobre Windows Azure",
                            Start = new DateTime(2014,3,29,9,0,0),
                            End = new DateTime(2014,3,29,9,45,0),
                            Speaker = "Lu�s Deschamps Rudge",
                            Title = "Overview Windows Azure"
                        },new Talk { 
                            Description = "LAB",
                            Start = new DateTime(2014,3,29,9,45,0),
                            End = new DateTime(2014,3,29,11,0,0),
                            Speaker = "-",
                            Title = "Lab: Luta contra diabetes"
                        },new Talk { 
                            Description = "Entenda o que � Azure Mobile Services e como utiliz�-lo com sucesso no seu app!",
                            Start = new DateTime(2014,3,29,11,0,0),
                            End = new DateTime(2014,3,29,11,30,0),
                            Speaker = "Andr� Carlucci",
                            Title = "Windows Azure Mobile Services"
                        },new Talk { 
                            Description = "Confira como utilizar o Azure como uma extens�o da sua empresa!",
                            Start = new DateTime(2014,3,29,11,30,0),
                            End = new DateTime(2014,3,29,12,0,0),
                            Speaker = "Lu�s Deschamps Rudge",
                            Title = "M�quinas virtuais e VPN"
                        },new Talk { 
                            Description = "Almo�o gr�tis no local",
                            Start = new DateTime(2014,3,29,12,0,0),
                            End = new DateTime(2014,3,29,13,0,0),
                            Speaker = "-",
                            Title = "Almo�o"
                        },new Talk { 
                            Description = "LAB",
                            Start = new DateTime(2014,3,29,13,0,0),
                            End = new DateTime(2014,3,29,16,45,0),
                            Speaker = "-",
                            Title = "Labs (Virtual Machines, VPN, Mobile Services, WebSites)"
                        },new Talk { 
                            Description = "Encerramento",
                            Start = new DateTime(2014,3,29,16,45,0),
                            End = new DateTime(2014,3,29,17,0,0),
                            Speaker = "-",
                            Title = "Encerramento"
                        }
                    }
                }
            );

            context.Companies.AddOrUpdate(new Company{
                Name = "Way2 Techonology",
                Description = "A Way2 desenvolve softwares e servi�os para telemedi��o e gest�o de dados de medi��o de energia. Sediada em Florian�polis, Santa Catarina, a empresa possui uma equipe multidisciplinar especializada no atendimento �s demandas de empresas do setor el�trico, como geradoras, transmissoras, distribuidoras e comercializadoras.",
                Site = "http://way2.com.br",
                Address = "Rodovia SC 401, Km 04, Espa�o Primavera Garden - Bloco B",
                LogoUrl = "http://i.imgur.com/Slsbsu1.png"
                }
            );
            context.Companies.AddOrUpdate(new Company{
                Name = "Bravi Software",
                Description = "A Bravi Software � uma empresa que desenvolve solu��es e tecnologia para o mercado da educa��o.",
                Site = "http://bravisoftware.com/",
                Address = "Rodovia SC 401, n� 8600 - Sala 4, bloco 08",
                LogoUrl = "http://bravisoftware.com/img/bg-logo.png"
                }
            );


        }
    }
}
