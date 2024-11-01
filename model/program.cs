  builder.Services.AddDbContext<ApplicationDb>(options => options.UseSqlServer
  (builder.Configuration.GetConnectionString("DefaultConnection")));