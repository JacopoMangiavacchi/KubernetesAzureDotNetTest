docker build -t backend .

docker run -d --name testbackend --publish=8090:8030 backend

docker login jcontainerregistry.azurecr.io

docker tag backend jcontainerregistry.azurecr.io/backend

docker push jcontainerregistry.azurecr.io/backend




