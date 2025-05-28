import java.sql.*;

class StudentDAO {
    private Connection con;

    public StudentDAO(Connection con) {
        this.con = con;
    }

    public void insertStudent(int id, String name) throws SQLException {
        String sql = "INSERT INTO students (id, name) VALUES (?, ?)";
        try (PreparedStatement pstmt = con.prepareStatement(sql)) {
            pstmt.setInt(1, id);
            pstmt.setString(2, name);
            pstmt.executeUpdate();
        }
    }

    public void updateStudentName(int id, String newName) throws SQLException {
        String sql = "UPDATE students SET name = ? WHERE id = ?";
        try (PreparedStatement pstmt = con.prepareStatement(sql)) {
            pstmt.setString(1, newName);
            pstmt.setInt(2, id);
            pstmt.executeUpdate();
        }
    }

    // Sample main for testing
    public static void main(String[] args) {
        String url = "jdbc:mysql://localhost:3306/testdb";
        String user = "root";
        String password = "password";

        try (Connection con = DriverManager.getConnection(url, user, password)) {
            StudentDAO dao = new StudentDAO(con);
            dao.insertStudent(101, "John Doe");
            dao.updateStudentName(101, "John Smith");
            System.out.println("Insert and update done.");
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
