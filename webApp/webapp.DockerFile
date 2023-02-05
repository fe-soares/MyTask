FROM node:16-alpine

WORKDIR /app

COPY package.json /app
COPY package-lock.json /app

RUN npm install --force

COPY . /app

EXPOSE 4200

CMD node_modules/.bin/ng serve --host 0.0.0.0 --disable-host-check

#comando terminal para gerar a imagem e rodar o docker
# docker build -t webapp_exemplo -f teste.DockerFile .

# docker run --rm -it -p 4201:4200 webapp_exemplo
#estara rodando o docker respondendo na porta 4202 da maquina mas 4200 no docker