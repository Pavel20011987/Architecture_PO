package ru.geekbrains.lesson1.homework.ModelElements;
import ru.geekbrains.lesson1.homework.InMemoryModel.ModelStore;

import java.util.List;



/**
 * Сцена
 * TODO: Доработать самостоятельно в рамках домашней работы
 */
public class Scene {
    private int id;
    private List<PoligonalModel> models;
    private List<Flash> flashes;
    private Camera camera;
    private ModelStore modelStore;

    public Scene(int id, List<PoligonalModel> models, List<Flash> flashes, Camera camera, ModelStore modelStore) {
        this.id = id;
        this.models = models;
        this.flashes = flashes;
        this.camera = camera;
        this.modelStore = modelStore;
    }

    public void loadScene() {
        // Логика загрузки сцены, например, чтение данных из файла или базы данных
    }

    public void renderScene() {
        // Логика отрисовки сцены, например, использование моделей и камеры для создания изображения
    }

    // другие методы

    public void addModel(PoligonalModel model) {
        models.add(model);
    }

    public void removeModel(PoligonalModel model) {
        models.remove(model);
    }

    public List<PoligonalModel> getModels() {
        return models;
    }

    public void setModels(List<PoligonalModel> models) {
        this.models = models;
    }

    public void addFlash(Flash flash) {
        flashes.add(flash);
    }

    public void removeFlash(Flash flash) {
        flashes.remove(flash);
    }

    public List<Flash> getFlashes() {
        return flashes;
    }

    public void setFlashes(List<Flash> flashes) {
        this.flashes = flashes;
    }

    public Camera getCamera() {
        return camera;
    }

    public void setCamera(Camera camera) {
        this.camera = camera;
    }

    public ModelStore getModelStore() {
        return modelStore;
    }

    public void setModelStore(ModelStore modelStore) {
        this.modelStore = modelStore;
    }
}




