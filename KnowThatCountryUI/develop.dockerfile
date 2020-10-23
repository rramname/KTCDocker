FROM node:10.15.3-slim as build
WORKDIR /app2
COPY src ./src
COPY *.json ./
RUN npm install
RUN npm install -g @angular/cli@7.3.10
#ENV PATH /app2/node_modules/.bin:$PATH

CMD ng serve --host 0.0.0.0

#docker run --rm -it -v %cd%/src:/app2/src -p 4202:4200 --name=ktcui21 ktcui:21 /bin/bash
