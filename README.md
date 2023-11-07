# PruebaQual-It

15. - En la carpeta PruebaQualit esta el backend, realice la prueba con las indicaciones de .NET 7 un Entity Framwork como ORM, en la solucion hice la implementacion conectado a una base de datos en SQL Server que esta aprovisionada en un servicio de AWS
    - En la carpeta prueba-qualit-frontend esta el frontend, realice la prueba con las indicaciones de Next.JS 14 y React, en la solucion hice la implementacion de autenticacion con next-auth, la base de datos donde estan los usuarios esta aprovisionada en vercel con postgres
    - Las credenciales para realizar las pruebas de la autenticación son: - Email: user@nextmail.com
                                                                          - Password: 123456

16. - En la carpeta lambda_function esta el codigo de la funcion lo realice en python ya que me estaba presentando inconvenientes al realizarlo en .net se me estaba haciendo imposible hacerle pruebas
    - Tambien hay dos imagenes una en donde muestro la funcion con un desencadenador cuando se carga una imagen en Bucket S3 y el destino son SNS para el envio del mensaje, la otra imagen es una prueba del correo

17. - En la carpeta cloud_formation esta el archivo .yaml para el aprovisionamiento del cloud formation que es la infraestructura, en el .yaml se aprovisiona los servicios de S3 y el servicio de CloudFront que agiliza la distribucion de contenido web estatico
