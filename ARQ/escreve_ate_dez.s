.data
msg:  .asciiz "PROGRAMA: ESCREVE ATE DEZ"
msg2: .asciiz "\n"
msg3: .asciiz "\n\nObrigado!\nTudorial de: Elias Flavio de Paiva\nPara a disciplina de Arquitetura de Computadores\nSegundo Semestre de Sistemas de Informacao\nPUC Minas - Contagem"

.text
main:   addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg		#Informa o ponto inicial da string, aqui � o nome do programa
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa

	addi $v0,$zero,1	#Escreve um inteiro na tela
	add  $a0,$zero,$zero	#Carrega o inteiro a ser escrito, aqui � o 0
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa

	addi $v0,$zero,1	#Escreve um inteiro na tela
	addi $a0,$zero,1	#Carrega o inteiro a ser escrito, aqui � o 1
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa

	addi $v0,$zero,1	#Escreve um inteiro na tela
	addi $a0,$zero,2	#Carrega o inteiro a ser escrito, aqui � o 2
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa

	addi $v0,$zero,1	#Escreve um inteiro na tela
	addi $a0,$zero,3	#Carrega o inteiro a ser escrito, aqui � o 3
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa

	addi $v0,$zero,1	#Escreve um inteiro na tela
	addi $a0,$zero,4	#Carrega o inteiro a ser escrito, aqui � o 4
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa

	addi $v0,$zero,1	#Escreve um inteiro na tela
	addi $a0,$zero,5	#Carrega o inteiro a ser escrito, aqui � o 5
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa

	addi $v0,$zero,1	#Escreve um inteiro na tela
	addi $a0,$zero,6	#Carrega o inteiro a ser escrito, aqui � o 6
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa

	addi $v0,$zero,1	#Escreve um inteiro na tela
	addi $a0,$zero,7	#Carrega o inteiro a ser escrito, aqui � o 7
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa

	addi $v0,$zero,1	#Escreve um inteiro na tela
	addi $a0,$zero,8	#Carrega o inteiro a ser escrito, aqui � o 8
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa

	addi $v0,$zero,1	#Escreve um inteiro na tela
	addi $a0,$zero,9	#Carrega o inteiro a ser escrito, aqui � o 9
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg2		#Informa o ponto inicial da string, aqui � o nome quebra de linha
	syscall			#Chama o sistema Operacional para executar a tarefa

	addi $v0,$zero,1	#Escreve um inteiro na tela
	addi $a0,$zero,10	#Carrega o inteiro a ser escrito, aqui � o 10
	syscall			#Chama o sistema Operacional para executar a tarefa
	
	addi $v0,$zero,4	#Escreve uma string na tela
	la   $a0,msg3		#Informa o ponto inicial da string, aqui s�o os agradecimentos
	syscall			#Chama o sistema Operacional para executar a tarefa

	jr $ra