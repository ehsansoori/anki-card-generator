# Anki Card Generator API

A simple and extensible ASP.NET Core Web API that generates flashcards for Anki using AI-ready architecture.

## 🚀 Features

- Generate flashcards from words or sentences
- Clean architecture (Controller → Service → DTO)
- Ready for AI integration (OpenAI, dictionary APIs)
- Swagger UI for easy testing
- Designed for future expansion (Anki export, mobile app, etc.)

## 🛠️ Tech Stack

- .NET (ASP.NET Core Web API)
- C#
- Swagger (Swashbuckle)

## 📦 Project Structure

- Controllers → API endpoints
- Services → Business logic
- DTOs → Data transfer objects

## 📌 API Endpoint

### Generate Cards

```http
POST /api/cards/generate