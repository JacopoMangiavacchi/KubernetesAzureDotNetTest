docker build -t backend .

docker run -d --name testbackend --publish=8090:8030 backend

docker login jcontainerregistry.azurecr.io

docker tag backend jcontainerregistry.azurecr.io/backend

docker push jcontainerregistry.azurecr.io/backend


az aks login
az aks get-credentials --resource-group JContainer --name jKubeCluster


kubectl create secret docker-registry jazurecontainersecret --docker-server  jcontainerregistry.azurecr.io --docker-email <YOUR_MAIL> --docker-username=<SERVICE_PRINCIPAL_ID> --docker-password <YOUR_PASSWORD>


az aks browse --resource-group JContainer --name jKubeCluster


