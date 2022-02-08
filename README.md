# os-demo-api
Simple .NET 6 API used to demo :
- Rancher Desktop (https://rancherdesktop.io/) and nerdCTL (https://github.com/containerd/nerdctl)
- Red Hat Universal Base Image (UBI) (https://developers.redhat.com/products/rhel/ubi)

To be built, pushed, and run in an OpenShift environment

Prereq's
- Rancher Desktop Installed and Configured

Build Image:
- nerdctl build -t os-demo-api .

View Image: (Note : <image-id-ref>)
- nerdctl images

Run a Container based on this Image
- nerdctl run -dp 8080:8080 os-demo-api

Confirm Container Instance Status (Note : <container-id-ref>)
- nerdctl ps

View Container
- http://localhost:8080/WeatherForecast

View Container (With ContainerId in Response)
- http://localhost:8080/OpenShiftPoC

Stop Container
- nerdctl stop <container-id-ref>

View Stopped Container
- nerdctl ps -a

Remove Container
- nerdctl rm <container-id-ref>

Remove Image
- nerdctl rmi <image-id-ref>