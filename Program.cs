using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTk5NDQ3OEAzMjMxMmUzMjJlMzNvWW5QZnphbUtoeUZuVFgzd2x0dnM2Z3phbW1jYVBjNjExYzIyRktNOG9vPQ==;Mgo+DSMBaFt+QHJqVk1lQ1BDaV1CX2BZeVl3Qmlce04BCV5EYF5SRHNeQl1kSHlWckBkUHY=;Mgo+DSMBMAY9C3t2VFhiQlJPc0BDWnxLflF1VWRTfll6cVFWESFaRnZdQV1mSH5TcURkXHtYcXRc;Mgo+DSMBPh8sVXJ1S0R+X1pBaV5FQmFJfFBmQmlYeFR1cEU3HVdTRHRcQlhiSX5Ud0JmXXlYeH0=;MTk5NDQ4MkAzMjMxMmUzMjJlMzNMYVZRVmd2NDJDdXVVS3prclc2ZlJSaE1RTUVjZC8ycWhVU2dOeWhvY1lNPQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfVpdXGRWfFN0RnNedV93flBCcC0sT3RfQF5jTH9TdkJiXnpad3NWRw==;ORg4AjUWIQA/Gnt2VFhiQlJPc0BDWnxLflF1VWRTfll6cVFWESFaRnZdQV1mSH5TcURkXHtZeH1U;MTk5NDQ4NUAzMjMxMmUzMjJlMzNkUW5kWVdtZFFrK2JBZllpclhxK2Rya3QwVGcyRW02Nnc3Q0VtMkM0emlnPQ==;MTk5NDQ4NkAzMjMxMmUzMjJlMzNDZ2ZwQWtXT0Z2Uy9wL3FpVHh0TDJWbzFNOGx0Y3A2V3ZzMnBBVHNRVE5JPQ==;MTk5NDQ4N0AzMjMxMmUzMjJlMzNlNzlXZXJPMEFLeGk1MEIzOUxpMk5Pdm1jRFl2NURQcVJGRFprN2UyajRFPQ==;MTk5NDQ4OEAzMjMxMmUzMjJlMzNBSmNOMkRPRnk3K1hMODNjdmg5UDVDQ1RIWVJBZTlDVEpSQ3h0cUt3OG1zPQ==;MTk5NDQ4OUAzMjMxMmUzMjJlMzNvWW5QZnphbUtoeUZuVFgzd2x0dnM2Z3phbW1jYVBjNjExYzIyRktNOG9vPQ==\r\n");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
