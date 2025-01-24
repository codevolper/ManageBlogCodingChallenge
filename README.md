# ManageBlogCodingChallenge
This repository has a coding challenge just to show a simple code solution

# Blog API Application
This project is an ASP.NET Core Web API application that provides a simple in-memory data store for managing blog posts and comments. 
The application uses a DataSet to store blog posts and their associated comments, and includes endpoints to create and retrieve blog posts and comments.

# Features

- Create Blog Posts: Add new blog posts.
- Create Comments: Add comments to existing blog posts.
- Retrieve Blog Posts: Get details of a single blog post, including its comments (counter).
- Retrieve All Blog Posts: Get a list of all blog posts with their total of the comments (counter). 
- Comment Count: Each blog post includes a count of its comments.

# Prerequisites
- .NET 8 SDK
- Visual Studio 2022 or any preferred IDE

# Installation

* 1 - Clone the repository
```
  git clone https://github.com/codevolper/ManageBlogCodingChallenge
```

* 2 - Restore dependencies
```
  dotnet restore
```
  
* 3 - Build the project:
```
dotnet build
```

* 4 - Run the application:
```
dotnet run --project ManageBlogServiceAPI.sln
```

 # API Endpoints
## Create a Blog Post
  
- #### URL: POST /api/posts
- #### Request Body:
```  
{
  "id": 1,
  "title": "First Blog Post",
  "content": "This is the content of the first blog post."
}

```
  
## Add a Comment to a Blog Post
#### URL: POST /api/posts/{id}/comments
#### Request Body:
```
{
  "id": 1,
  "author": "Author Comment",
  "content": "Content Comment",  
}
```

## Get all posts
#### URL: GET /api/posts

## Get a post by Id 
#### URL: GET /api/posts/{id}

# Project Structure
- Core: Contains domain entities such as BlogPost and Comment.
- Infrastructure: Contains repository implementations for data access.
- WebAPI: Contains API controllers and configurations.

# Dependencies
- ASP.NET Core 8.0
- System.Data
