//O princípio que estava sendo aferido é o Princípio da Responsabilidade Única.
//Onde o mesmo afirma que uma classe deve ter apenas uma razão para mudar, ou seja, uma classe tem apenas uma responsabilidade
//e não deve estar sobrecarregada com outras responsabilidades.

//A API estava acumulando muitas responsabilidades, incluindo regras de negócio, validações e persistência em uma única classe ou módulo.
//Fazendo com que o código fique difícil de manter, testar e modificar, pois o sistema está todo interligado.

//Para corrigir isso, precisamos deste princípio para separação das diferentes responsabilidades  da API em classes ou módulos separados.
//Tendo partes separadas no código, isolada para regra de negócio, validação e persistência. Assim, tornamos o código mais organizado,
//legível, fácil de manter e ajudando a fazer testes unitários em cada parte isolada do código.