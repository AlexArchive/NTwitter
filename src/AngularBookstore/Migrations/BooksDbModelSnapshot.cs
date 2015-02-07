using AngularBookstore.Models;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;

namespace AngularBookstore.Migrations
{
    [ContextType(typeof(AngularBookstore.Models.BooksDb))]
    public class BooksDbModelSnapshot : ModelSnapshot
    {
        public override IModel Model
        {
            get
            {
                var builder = new BasicModelBuilder();
                
                builder.Entity("AngularBookstore.Models.Book", b =>
                    {
                        b.Property<string>("Author");
                        b.Property<int>("Id")
                            .GenerateValueOnAdd();
                        b.Property<string>("Title");
                        b.Key("Id");
                    });
                
                return builder.Model;
            }
        }
    }
}