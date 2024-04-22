# Learn AZ-104 in 2024

I am learning AZ-104 from different video courses, websites, and books.

## Few Points

> 1. `curl -kL https://localhost:7139/`

```powershell
cd ~/BestBikeApp
dotnet publish -o pub
cd pub
zip -r BestBikes.WebApp.zip *
```

```powershell
$rgname = 'rg-az104-dev-001'
$webappname = 'app-bestbikesweb'
az webapp deployment source config-zip --src BestBikes.WebApp.zip --resource-group $rgname --name $webappname
```

![az webapp deployment](documentation/images/az-webapp-deployment.PNG)

## Sample 2

```powershell
docker pull mcr.microsoft.com/dotnet/samples:aspnetapp

docker image list

docker run mcr.microsoft.com/dotnet/samples:aspnetapp

docker run -p 8080:80 -d mcr.microsoft.com/dotnet/samples:aspnetapp

docker ps
docker ps -a
docker container ls
docker stop elegant_ramanujan

docker start elegant_ramanujan

docker rm elegant_ramanujan

docker container rm -f elegant_ramanujan

docker image rm mcr.microsoft.com/dotnet/core/samples:aspnetapp
```

```powershell
docker build -t hotelreservationsystemapi -f .\HotelReservationSystem.API\Dockerfile .

docker image list

docker ps -a

docker run -p 8080:8080 -d --name reservations hotelreservationsystemapi
```

```powershell
$rgname = 'rg-az104-dev-001'
az group create --name $rgname --location westus

az acr create --name <unique name> --resource-group $rgname --sku standard --admin-enabled true

docker login acraz104dev001.azurecr.io

az acr credential show --name acraz104dev001 --resource-group $rgname

docker tag hotelreservationsystemapi acraz104dev001.azurecr.io/hotelreservationsystemapi:v2

docker push acraz104dev001.azurecr.io/hotelreservationsystemapi:v2

az acr repository list --name acraz104dev001 --resource-group $rgname

az acr repository show --repository hotelreservationsystemapi --name acraz104dev001 --resource-group $rgname

az container create --resource-group $rgname --name acihotelreservationsystemapi --image acraz104dev001.azurecr.io/myapp:latest --dns-name-label acihotelreservationsystemapi --registry-username <username> --registry-password <password>

az container show --resource-group $rgname --name acihotelreservationsystemapi --query ipAddress.fqdn
```
