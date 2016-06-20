namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creacionpassworddefecto : DbMigration
    {
        public override void Up()
        {
            AddColumn("ALIMENTOSSANTIAGO.Empresas", "PasswordDefecto", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("ALIMENTOSSANTIAGO.Empresas", "PasswordDefecto");
        }
    }
}
