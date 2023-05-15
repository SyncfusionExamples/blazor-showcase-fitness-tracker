using FitnessTracker.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqVk1mQ1NbdF9AXnNPdFJwT2ZRby8Nf1dGYl9RQXZcQltiT3tac0JiXw==;Mgo+DSMBPh8sVXJ1S0R+X1pCaV1dX2NLfUNwT2JfdVt4ZCQ7a15RRnVfR11gSXhScEBqXHdWdg==;ORg4AjUWIQA/Gnt2VFhiQlJPcEBAQmFJfFBmQ2lYeVR1fEU3HVdTRHRcQlhjSn5Vd0NmUHledXI=;MTkwNTk5OUAzMjMxMmUzMjJlMzNUYkZFZllQTDNlRC8xR1Evb2ZqZS9KZktKd21yc1VxK2lQajFVS3g5UHRZPQ==;MTkwNjAwMEAzMjMxMmUzMjJlMzNpbysxeWhGbHVJMHVKOXFKbVhPanZJQWk2WXgwREhwUStrTWo5dExmSDZnPQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfVldX3xLflF1VWVTflh6cV1WESFaRnZdQV1mSX1TcERlXHZYdnBT;MTkwNjAwMkAzMjMxMmUzMjJlMzNqZCtFcFFhZEVUbXpZVzdlYjFyRk9xSVZPYzEyZ0ZDcnlvRWlXZ3R2K1dvPQ==;MTkwNjAwM0AzMjMxMmUzMjJlMzNqVWh1SGZhWGNvdWVad0M2RHRyVkgyYnN6bXVCcUlEai9wcDZMMFhLUmprPQ==;Mgo+DSMBMAY9C3t2VFhiQlJPcEBAQmFJfFBmQ2lYeVR1fEU3HVdTRHRcQlhjSn5Vd0NmUHhccnI=;MTkwNjAwNUAzMjMxMmUzMjJlMzNBaldxVGQ3SG55YjhNRWlsQTU2eVRJOEViTTJmQUxwblA5aWc0cjg4TTFrPQ==;MTkwNjAwNkAzMjMxMmUzMjJlMzNLV3lDdTR2eVl5K3VINGlpUWRpSGs5NTVMYnluNUJ1eEMvd1hFMjRvT1V3PQ==;MTkwNjAwN0AzMjMxMmUzMjJlMzNqZCtFcFFhZEVUbXpZVzdlYjFyRk9xSVZPYzEyZ0ZDcnlvRWlXZ3R2K1dvPQ==");
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<FitnessService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
