Para reproduzir o projeto:

- Clone o repositório;
- Adicione uma instância do SQLServer ao projeto;
- No arquivo appsettings.json coloque a string de conexão do banco na opção "DefaultConnection", como no exemplo abaixo:

"ConnectionStrings": {
  "DefaultConnection": "Data Source=DESKTOP-BI2V6H4;Initial Catalog=InsaragSystemDB;Integrated Security=True;Trust Server Certificate=True"
}

- Abra o console do gerenciador de pacotes NuGet e selecione InsaragSystem.Infra.Data como projeto padrão;
- Digite Update-Database para que as migrations sejam implementadas e o banco atualizado;

Aqui estão imagens das telas onde ocorrem as operações CRUD.

![image](https://github.com/higoreller/InsaragSystem/assets/87211773/59bcfc2b-f9d8-4a80-b144-217bdd4a5ecc)

![image](https://github.com/higoreller/InsaragSystem/assets/87211773/b2cddbef-ae2b-4d91-b28d-fda8d0faf130)

![image](https://github.com/higoreller/InsaragSystem/assets/87211773/751c3544-d8a9-4524-ad1c-a611dd9cd275)

![image](https://github.com/higoreller/InsaragSystem/assets/87211773/77cf0dc9-81eb-4c45-ad08-8a161dc1a66f)

![image](https://github.com/higoreller/InsaragSystem/assets/87211773/fee8594a-e3db-477b-ae8c-68e94111073a)
