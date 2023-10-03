//Usar propriedades com set privado em classes da camada de domínio oferece controle sobre a mutabilidade dos dados,
//permite validação de dados, promove o encapsulamento, facilita a evolução do sistema,
//adere a padrões de design, melhora o debugging e rastreamento, e mantém a integridade dos dados,
//especialmente em casos como o preço de um produto.

//Um exemplo prático dessa abordagem pode ser visto com um objeto "Produto". 
//Se uma propriedade como o preço de um produto tiver um set privado, você pode garantir que qualquer 
//alteração no preço seja validada e controlada pela classe de produto.
//Isso evita cenários em que o preço pode ser definido como um valor negativo, por exemplo,
//e mantém a consistência dos dados em todo o sistema.