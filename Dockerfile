FROM mcr.microsoft.com/dotnet/sdk:9.0 AS docfx

WORKDIR /app

RUN dotnet tool install --global docfx
ENV PATH="${PATH}:/root/.dotnet/tools"

COPY . .

RUN docfx build docfx/docfx.json

EXPOSE 8080

CMD ["docfx", "serve", "docfx/_site", "--port", "8080", "--hostname", "0.0.0.0"]
