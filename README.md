# Personal Blog App

In this project, I share a project used to create a personal blogging application. This application allows users to create, edit and publish blog posts.

## Features

- Users can create an account and log in by registering.
- Logged-in users can create new blog posts, and edit and publish existing posts.
- Users can add titles, content, and categories to their posts.
- All blog posts are listed on the homepage and can be read by users.
- Users can filter blog posts by category.
- Blog posts can be commented on and comments can be viewed.
- Users can edit their own accounts and update their profile information.
- Users can delete their accounts and remove blog posts along with all their data.

## Installation

1. Clone this project: `git clone https://github.com/iamyasinkaya/Personal-Blog-Application.git`
2. Go to the project directory: `cd Personal-Blog-Application`
3. Install the required dependencies:
   - This may vary depending on the package manager used for the project.
   - If you are using Visual Studio, dependencies are usually installed automatically when you open the project.
   - If you are using .NET CLI, you can run the following command: `dotnet restore`
4. Configure the database:
   - Open `appsettings.json` (or your equivalent configuration file) and adjust your database connection settings.
   - For example, if you are using Entity Framework and SQL Server, update the "ConnectionStrings" section.
5. Build and run the application:
   - If you are using Visual Studio, you can just open the solution file and run the application.
   - If you are using .NET CLI, you can run the following commands:
     ```
     dotnet build
     dotnet run
     ```

## Usage

- When the application is launched, open `http://localhost:3000` in your browser.
- On the homepage, register or log in with an existing account.
- Once logged in, you can create a new blog post or edit existing ones.
- You can use the menu in the top right corner to filter posts by category.
- To comment on posts, you can use the comment section at the bottom of the post.
- For the user profile, you can click on your avatar in the top right corner.
- You can edit your account settings or delete your account on the profile page.

## Contributing
To make a contribution, please review the CONTRIBUTING.md file.
