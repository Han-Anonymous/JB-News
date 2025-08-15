# JB-News

This library is a comprehensive wrapper for JBlanked's News API. It leverages the power of OpenAI, Machine Learning, and MQL5's Calendar to provide developers with easy access to news data across all computer languages, including MQL4. Full documentation: https://www.jblanked.com/news/api/docs/

## Features

- Easy access to JBlanked's News API
- Access to News Event History, Machine Learning Predictions, Smart Analysis, and more.
- Access to News Calendar
- Supports MQL4 and any other language that can make HTTP requests.

## C# .NET API Usage

The C# .NET API provides a backend service that proxies requests to the JBlanked News API. To use it, you will need to run the API project and make HTTP requests to the endpoints it exposes.

### Running the API

1.  Navigate to the `csharp_api` directory.
2.  Run the command `dotnet run`.
3.  The API will be available at `https://localhost:5001` (or a similar address).

### API Endpoints

All endpoints require an `Authorization` header with your API key from `https://www.jblanked.com/profile/`.

- `GET /news/api/{news_source}/full-list/`: Retrieves the full list of news events.
- `GET /news/api/{news_source}/calendar/`: Retrieves the calendar of news events.
- `GET /news/api/{news_source}/calendar/today/`: Retrieves today's calendar of news events.
- `GET /news/api/{news_source}/calendar/week/`: Retrieves this week's calendar of news events.
- `POST /news/api/gpt/`: Sends a message to the NewsGPT model. The body of the request should be a JSON object with a `content` property, for example: `{"content": "What does bullish mean in forex?"}`.
- `GET /news/api/gpt/status/{task_id}/`: Retrieves the status of a NewsGPT task.

This API is freely accessible through our library and through GET requests. Get your API key from: https://www.jblanked.com/profile/. Note that the free tier has a rate limit of once every 5 minutes, but VIP members enjoy unrestricted access.
