FROM nginx:alpine
COPY /DockerFiles/default.conf /etc/nginx/conf.d/default.conf
COPY /Build /var/share/nginx/html