package ru.geekbrains.lesson1.homework.ModelElements;

/**
 * Камера
 * TODO: Доработать самостоятельно в рамках домашней работы
 */
public class Camera {
    private Point3D location;
    private Angle3D angle;

    public Camera(Point3D location, Angle3D angle) {
        this.location = location;
        this.angle = angle;
    }

    public void rotate(Angle3D rotationAngle) {
        float newAngleX = angle.getX() + rotationAngle.getX();
        float newAngleY = angle.getY() + rotationAngle.getY();
        float newAngleZ = angle.getZ() + rotationAngle.getZ();
        angle = new Angle3D(newAngleX, newAngleY, newAngleZ);
    }

    public void move(Point3D newPosition) {
        float newX = (float) (location.getX() + newPosition.getX());
        float newY = (float) (location.getY() + newPosition.getY());
        float newZ = (float) (location.getZ() + newPosition.getZ());
        location = new Point3D(newX, newY, newZ);
    }

    public Point3D getLocation() {
        return location;
    }

    public void setLocation(Point3D location) {
        this.location = location;
    }

    public Angle3D getAngle() {
        return angle;
    }

    public void setAngle(Angle3D angle) {
        this.angle = angle;
    }
}