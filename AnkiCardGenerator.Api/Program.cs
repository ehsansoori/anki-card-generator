using AnkiCardGenerator.Api.Factories;
using AnkiCardGenerator.Api.Interfaces;
using AnkiCardGenerator.Api.Prompts;
using AnkiCardGenerator.Api.Providers;
using AnkiCardGenerator.Api.Services;
using AnkiCardGenerator.Api.Templates;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//Add new services
builder.Services.AddScoped<ICardService, CardService>();
builder.Services.AddScoped<IDictionaryProvider, MockDictionaryProvider>();
//AI Provider
builder.Services.AddHttpClient<OpenAiProvider>();
builder.Services.AddScoped<IAiProvider, MockAiProvider>();
builder.Services.AddScoped<IAiProvider, OpenAiProvider>();
//AI Prompt
builder.Services.AddScoped<AiPromptFactory>();


builder.Services.AddScoped<DictionaryProviderFactory>();
builder.Services.AddScoped<AiProviderFactory>();
builder.Services.AddScoped<ICardTemplate, BasicVocabularyTemplate>();
builder.Services.AddScoped<TemplateFactory>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
