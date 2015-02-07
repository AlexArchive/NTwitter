using AngularBookstore.Models;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;

namespace AngularBookstore.Migrations
{
    [ContextType(typeof(AngularBookstore.Models.BooksDb))]
    public partial class initial : IMigrationMetadata
    {
        string IMigrationMetadata.MigrationId
        {
            get
            {
                return "201502072252183_initial";
            }
        }
        
        string IMigrationMetadata.ProductVersion
        {
            get
            {
                return "7.0.0-beta2-11909";
            }
        }
        
        IModel IMigrationMetadata.TargetModel
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