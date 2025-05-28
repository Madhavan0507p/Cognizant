import java.sql.*;

class TransactionHandling {
    public static void transferMoney(Connection con, int fromAccount, int toAccount, double amount) throws SQLException {
        String debitSQL = "UPDATE accounts SET balance = balance - ? WHERE id = ?";
        String creditSQL = "UPDATE accounts SET balance = balance + ? WHERE id = ?";

        try {
            con.setAutoCommit(false);

            try (PreparedStatement debitStmt = con.prepareStatement(debitSQL);
                 PreparedStatement creditStmt = con.prepareStatement(creditSQL)) {

                debitStmt.setDouble(1, amount);
                debitStmt.setInt(2, fromAccount);
                debitStmt.executeUpdate();

                creditStmt.setDouble(1, amount);
                creditStmt.setInt(2, toAccount);
                creditStmt.executeUpdate();

                con.commit();
                System.out.println("Transaction successful");
            } catch (SQLException e) {
                con.rollback();
                System.out.println("Transaction failed. Rolled back.");
                throw e;
            }
        } finally {
            con.setAutoCommit(true);
        }
    }

    public static void main(String[] args) {
        String url = "jdbc:mysql://localhost:3306/testdb";
        String user = "root";
        String password = "password";

        try (Connection con = DriverManager.getConnection(url, user, password)) {
            transferMoney(con, 1, 2, 500);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
