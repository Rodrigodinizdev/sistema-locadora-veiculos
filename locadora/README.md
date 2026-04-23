# sistema-locadora-veiculos

🚗 Projeto: Sistema de Locadora de Veículos "DriveNow"
📌 Contexto

O sistema deve gerenciar Clientes, Veículos, Locações e Pagamentos.
Como ainda não há banco de dados, os dados devem ser armazenados em List<T> em memória durante a execução.

🎯 Regras de Negócio (O "Desafio")
🚘 Status do Veículo
Um veículo só pode ser alugado se estiver com status Disponível.
Ao realizar uma locação:
O status do veículo deve mudar automaticamente para Indisponível.
Ao finalizar a locação (devolução):
O veículo volta para Disponível.

👤 Limite de Locações por Cliente
Um cliente pode ter no máximo 2 locações ativas simultaneamente.
Caso tente iniciar uma terceira:
O sistema deve impedir a operação.
Exibir mensagem: "Limite de locações atingido."

📅 Regra de Devolução e Multa
Ao devolver um veículo:
O sistema deve verificar a DataPrevistaDevolucao e a DataRealDevolucao.
Se houver atraso:
Calcular multa de R$ 50,00 por dia de atraso.
A quilometragem rodada deve ser informada na devolução.

O valor final da locação será:

(Dias * ValorDiaria) + Multa (se houver)

💳 Regra de Pagamento
Toda locação finalizada deve gerar um pagamento.
O pagamento:
Deve estar vinculado à locação.
Deve possuir um tipo (Dinheiro, Cartão, Pix, etc).
Uma locação só é considerada encerrada quando o pagamento for realizado.
Após pagamento:
Status do pagamento = Pago
Locação é finalizada.

❌ Restrição de Exclusão
Veículo
Um veículo não pode ser removido se:
Estiver em uma locação ativa.
Cliente
Um cliente não pode ser removido se:
Possuir locações em aberto.

🔁 Atualização de Quilometragem
Ao finalizar uma locação:
A quilometragem rodada deve ser somada à quilometragem atual do veículo.

⚠️ Validações Importantes
Data de devolução prevista deve ser maior que a data de início.
Não permitir locação com datas inválidas.
Valor da diária deve ser maior que 0.

🧱 Estrutura Sugerida (POO)
Entidades:
Cliente
Endereco
Veiculo
Categoria
MarcaVeiculo
Locacao
Pagamento
TipoPagamento

🔧 Funcionalidades (CRUD)
Cliente
Cadastrar
Listar
Atualizar
Remover (com regra)
Veículo
Cadastrar
Listar
Atualizar status automaticamente
Remover (com regra)
Locação
Criar locação
Listar locações
Finalizar locação (devolução)
Pagamento
Registrar pagamento
Listar pagamentos

💡 Desafios Extras (Opcional)
Mostrar veículos disponíveis
Listar clientes com locações ativas
Relatório de faturamento total
Veículo mais alugado
