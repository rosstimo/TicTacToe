'Tic Tac Toe Game
'RCET0265 Fall 2021
'

Option Strict On
Option Explicit On
Option Compare Binary

'TODO:
'display game board console
'Player vs player
'evaluate win/draw
'new game, player turn, end game
'track wins per session (tournament play like best two out of three)

'Future:
'Allow choice of console game or graphical game (WinForm). web based asp.net if really ambitious
'

Module TicTacToe

    'store game/turn data. "X", "O", ""
    Private gameBoardData(2, 2) As String

    Sub Main()


    End Sub

    Function Winner() As String
        Dim _winner As String
        'TODO
        Return _winner
    End Function

    Private Function CheckRows() As String
        'TODO
        Return ""
    End Function

    Private Function CheckColumns() As String
        'TODO
        Return ""
    End Function

    Private Function CheckDiaginals() As String
        'TODO
        Return ""
    End Function

    Private Sub Turn()
        'TODO
    End Sub

    Private Sub DisplayGameBoard()
        'TODO
    End Sub

    Private Sub NewGame()
        'TODO
    End Sub

    ''' <summary>
    ''' Toggles the current player. 
    ''' </summary>
    ''' <returns>Either "X" or "O" As String</returns>
    Private Function CurrentPlayer() As String
        Static _currentPlayer As String

        Select Case _currentPlayer
            Case "X"
                _currentPlayer = "O"
            Case Else
                _currentPlayer = "X"
        End Select

        Return _currentPlayer
    End Function


End Module
