UPDATE
    Tabela
SET
    Tabela.Col01 = Outra_tabela.Col01,
    Tabela.Col02 = Outra_tabela.Col02
FROM
    Tabela as Tabela
  INNER JOIN Outra_tabela AS Outra_tabela
    ON Tabela.id = Outra_tabela.id
WHERE
    Condicao = 'Qualquer coisa'
